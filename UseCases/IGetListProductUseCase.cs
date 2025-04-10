namespace anh_ngoc_packaging.UseCases
{
    public interface IGetListProductUseCase
    {
        Task<ListProductResponseDto> Execute(GetListProductRequestDto param);
    }
}
