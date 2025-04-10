namespace anh_ngoc_packaging.UseCases
{
    public interface IGetListProductRelationUseCase
    {
        Task<ListProductResponseDto> Execute(GetListProductRelationRequestDto param);
    }
}
