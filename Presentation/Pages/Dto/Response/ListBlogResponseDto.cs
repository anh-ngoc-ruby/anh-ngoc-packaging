namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListBlogResponseDto : PagingResponseDto
    {
        public IEnumerable<ItemListBlogResponseDto> Items = Enumerable.Empty<ItemListBlogResponseDto>();
    }
    public class ItemListBlogResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsShow { get; set; } = true;
    }
}
