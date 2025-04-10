namespace anh_ngoc_packaging.UseCases
{
    public interface IGetListProductCategoryUseCase
    {
        Task<ListProductCategoryResponseDto> Execute();
    }
}
