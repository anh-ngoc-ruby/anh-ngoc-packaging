namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListProductCategoryResponseDto : PagingResponseDto
    {
        public IEnumerable<ItemListProductCategoryResponseDto> Items = Enumerable.Empty<ItemListProductCategoryResponseDto>();
    }

    public class ItemListProductCategoryResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
