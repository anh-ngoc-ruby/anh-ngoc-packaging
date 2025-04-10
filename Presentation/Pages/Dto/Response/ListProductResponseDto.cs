namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListProductResponseDto : PagingResponseDto
    {
        public IEnumerable<ItemListProductResponseDto> Items = Enumerable.Empty<ItemListProductResponseDto>();
        public ItemListComponentResponseDto Component { get; set; } = new ItemListComponentResponseDto();
    }
    public class ItemListProductResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public List<ItemListProductCategory> ProductCategories { get; set; } = new List<ItemListProductCategory>();
        public string Price { get; set; } = string.Empty;
        public string FinalPrice { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }

    public class ItemListProductCategory
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
