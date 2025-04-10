
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListProductCategoryUseCase : IGetListProductCategoryUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoryCollection;
        public GetListProductCategoryUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productCategoryCollection = context.ProductCategory;
        }
        public async Task<ListProductCategoryResponseDto> Execute()
        {
            var dataReturnException = new ListProductCategoryResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var banners = await this.productCategoryCollection
                  .Find(x => x.IsSubMenu == true)
                  .Project(banner => new ItemListProductCategoryResponseDto
                  {
                      Id = banner.Id,
                      Slug = banner.Slug,
                      Image = banner.Image,
                      Name = banner.Name,
                      Background = banner.Background,
                      Description = banner.Description
                  })
                  .ToListAsync();
                var dataReturn = new ListProductCategoryResponseDto
                {
                    Items = banners,
                };
                return dataReturn;
            }
            catch (Exception ex)
            {
                dataReturnException.Errors.Add(
                    new ErrorResponseDto
                {
                    Code = ex.GetType().Name,
                    Error = ex.Message
                });
            }
            return dataReturnException;
        }
    }
}
