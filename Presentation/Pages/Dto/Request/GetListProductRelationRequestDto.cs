namespace anh_ngoc_packaging.Presentation.Pages.Dto.Request
{
    public class GetListProductRelationRequestDto :PagingRequestDto
    {
        public List<String> ProductCateIds { get; set; } = new List<string>();
    }
}
