namespace anh_ngoc_packaging.Presentation.Pages.Dto.Request
{
    public class GetProductRequestDto : BaseRequestDto
    {
        [FromRoute(Name = "slug")]
        public string ProductSlug { get; set; } = string.Empty;
    }
}
