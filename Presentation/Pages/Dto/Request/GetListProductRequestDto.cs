namespace anh_ngoc_packaging.Presentation.Pages.Dto.Request
{
    public class GetListProductRequestDto : PagingRequestDto
    {
        [FromQuery(Name = "search")]
        public string Search { get; set; } = string.Empty;

        [FromQuery(Name = "danh-muc")]
        public string CategorySlug { get; set; } = string.Empty;

        public string CategoryId { get; set; } = string.Empty;
    }
}
