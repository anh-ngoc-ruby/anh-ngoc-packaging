namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListComponentResponseDto : PagingResponseDto
    {
        public IEnumerable<ItemListComponentResponseDto> Items = Enumerable.Empty<ItemListComponentResponseDto>();
    }

    public class ItemListComponentResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public ComponentConfigResponseDto Config { get; set; } = new ComponentConfigResponseDto();
        public ComponentContentResponseDto Content { get; set; } = new ComponentContentResponseDto();
        public bool IsActive { get; set; } = true;
        public int Priority { get; set; }
        public Dictionary<string, object> Extra { get; set; } = new Dictionary<string, object>();
    }

    public class ComponentConfigResponseDto
    {
        public string TitleColor { get; set; } = string.Empty;
        public string SubTitleColor { get; set; } = string.Empty;
        public string DescriptionColor { get; set; } = string.Empty;
        public string BackgroundColor { get; set; } = string.Empty;
        public string ButtonBackground { get; set; } = string.Empty;
        public string ButtonTextColor { get; set; } = string.Empty;
    }

    public class ComponentContentResponseDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public string Button { get; set; } = string.Empty;
        public string ButtonText { get; set; } = string.Empty;
        public string SubTitle { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
