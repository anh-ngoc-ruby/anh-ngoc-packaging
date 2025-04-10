
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetProductUseCase : IGetProductUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ProductEntity> productCollection;
        public GetProductUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.productCollection = context.Product;
        }
        public async Task<ProductDetailResponseDto> Execute(GetProductRequestDto param)
        {
            var dataReturnException = new ProductDetailResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var productDocument = await this.productCollection.Find(x => x.Slug.Equals(param.ProductSlug)).FirstOrDefaultAsync();
                if(productDocument == null)
                {
                    dataReturnException.Errors.Add(new ErrorResponseDto
                    {
                        Code = "not_found_product",
                        Error = "not_found_product"
                    });
                    return dataReturnException;
                }
                var productdto = this.mapper.Map<ProductDetailResponseDto>(productDocument);
                return productdto;
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
