
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListProductCategoryBannerUseCase : IGetListProductCategoryBannerUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductCategoryEntity> productCategoryCollection;
        public GetListProductCategoryBannerUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productCategoryCollection = context.ProductCategory;
        }
        public async Task<ListProductCategoryBannerResponseDto> Execute()
        {
            var dataReturnException = new ListProductCategoryBannerResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var banners = await this.productCategoryCollection
                  .Find(x=> x.IsBanner == true)  
                  .Project(banner => new ItemListProductCategoryBannerResponseDto
                  {
                      Id = banner.Id,
                      Slug = banner.Slug,
                      Image = banner.Image,
                      Name = banner.Name,
                      Background = banner.Background,
                      Description = banner.Description
                  })
                  .ToListAsync();
                var dataReturn = new ListProductCategoryBannerResponseDto
                {
                    Items = banners,
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
