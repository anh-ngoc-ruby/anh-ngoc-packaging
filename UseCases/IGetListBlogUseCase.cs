namespace anh_ngoc_packaging.UseCases
{
    public interface IGetListBlogUseCase
    {
        Task<ListBlogResponseDto> Execute(GetListBlogRequestDto param);
    }
}
