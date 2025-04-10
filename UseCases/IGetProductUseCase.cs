namespace anh_ngoc_packaging.UseCases
{
    public interface IGetProductUseCase
    {
        Task<ProductDetailResponseDto> Execute(GetProductRequestDto param);
    }
}
