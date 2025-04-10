namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListPolicyResponseDto : PagingResponseDto
    {
        public IEnumerable<ItemListPolicyResponseDto> Items = Enumerable.Empty<ItemListPolicyResponseDto>();
    }

    public class ItemListPolicyResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Priority { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
