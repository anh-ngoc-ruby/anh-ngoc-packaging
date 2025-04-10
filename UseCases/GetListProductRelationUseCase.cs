
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListProductRelationUseCase : IGetListProductRelationUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductEntity> productsCollection;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoriesCollection;
        public GetListProductRelationUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productsCollection = context.Product;
            this.productCategoriesCollection = context.ProductCategory;
        }
        public async Task<ListProductResponseDto> Execute(GetListProductRelationRequestDto param)
        {
            var dataReturnException = new ListProductResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                // 1. Tạo filter nếu có truyền ProductCateIds
                FilterDefinition<ProductEntity> filter = Builders<ProductEntity>.Filter.Empty;

                if (param.ProductCateIds != null && param.ProductCateIds.Any())
                {
                    filter = Builders<ProductEntity>.Filter.AnyIn(x => x.ProductCategoryIds, param.ProductCateIds);
                }

                // 2. Lấy danh sách sản phẩm có phân trang
                var products = await this.productsCollection
                    .Find(filter)
                    .Paging(param.Page, param.PageSize)
                    .ToListAsync();

                // 3. Lấy toàn bộ categoryId liên quan
                var productCategoryIds = products
                    .SelectMany(p => p.ProductCategoryIds)
                    .Distinct()
                    .ToList();

                // 4. Đếm tổng số bản ghi
                var productCount = await this.productsCollection.CountDocumentsAsync(filter);

                // 5. Lấy thông tin category
                var productCategories = await this.productCategoriesCollection
                    .Find(x => productCategoryIds.Contains(x.Id))
                    .ToListAsync();

                // 6. Gộp dữ liệu trả về
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

                return new ListProductResponseDto
                {
                    Items = data,
                    TotalCount = (int)productCount,
                    Page = param.Page,
                    PageSize = param.PageSize
                };
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
