
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListProductUseCase : IGetListProductUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductEntity> productsCollection;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoriesCollection;
        public GetListProductUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productsCollection = context.Product;
            this.productCategoriesCollection = context.ProductCategory;
        }
        public async Task<ListProductResponseDto> Execute(GetListProductRequestDto param)
        {
            var dataReturnException = new ListProductResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var filter = Builders<ProductEntity>.Filter.Empty;
                if (!string.IsNullOrEmpty(param.Search))
                {
                    var exactPhrase = $"\"{param.Search}\"";
                    filter = Builders<ProductEntity>.Filter.And(
                    filter,
                     Builders<ProductEntity>.Filter.Text(exactPhrase)
                 );
                }
                if (!string.IsNullOrEmpty(param.CategorySlug))
                {
                    var productCategory = await this.productCategoriesCollection
                        .Find(x => x.Slug.Equals(param.CategorySlug))
                        .FirstOrDefaultAsync();
                    if (productCategory != null)
                    {
                        filter = Builders<ProductEntity>.Filter.And(
                            filter,
                            Builders<ProductEntity>.Filter.AnyEq(x => x.ProductCategoryIds, productCategory.Id)
                        );
                    }
                }

                var products = await this.productsCollection.Find(filter).Paging(param.Page, param.PageSize).ToListAsync();
                var productIds = products.SelectMany(p => p.ProductCategoryIds).Distinct().ToList();
                var productCount = await this.productsCollection.CountDocumentsAsync(filter);
                var productCategories = await this.productCategoriesCollection.Find(x => productIds.Contains(x.Id)).ToListAsync();

                var data = products.Select(p =>
                {
                    var categories = productCategories
                        .Where(c => p.ProductCategoryIds.Contains(c.Id))
                        .Select(c => new ItemListProductCategory
                        {
                            Id = c.Id,
                            Name = c.Name
                        }).ToList();

                    return new ItemListProductResponseDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Image = p.Image,
                        Slug = p.Slug,
                        Price = p.Price,
                        FinalPrice = p.FinalPrice,
                        ProductCategories = categories
                    };
                }).ToList();

                var dataReturn = new ListProductResponseDto
                {
                    Items = data,
                    TotalCount = (int)productCount,
                    Page = param.Page,
                    PageSize = param.PageSize
                };
                return dataReturn;

            }
            catch (Exception ex)
            {
                dataReturnException.Errors.Add(new ErrorResponseDto
                {
                    Code = ex.GetType().Name,
                    Error = ex.Message
                });
            }
            return dataReturnException;
        }
    }
}
