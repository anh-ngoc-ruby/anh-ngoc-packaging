namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ProductDetailResponseDto : BaseResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public List<string> ProductCategoryIds { get; set; } = new List<string>();
        public string Price { get; set; } = string.Empty;
        public string FinalPrice { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public Dictionary<string, object>? Extra { get; set; } = new Dictionary<string, object>();

    }

    public class BlogProductDetailResponseDto
    {

    }
}
