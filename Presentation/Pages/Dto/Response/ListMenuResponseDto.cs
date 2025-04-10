namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListMenuResponseDto : PagingResponseDto
    {
        public IEnumerable<ItemListMenuResponseDto> Items = Enumerable.Empty<ItemListMenuResponseDto>();
    }

    public class ItemListMenuResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsSubMenu { get; set; } = false;
        public int Priority { get; set; }
    }
}
