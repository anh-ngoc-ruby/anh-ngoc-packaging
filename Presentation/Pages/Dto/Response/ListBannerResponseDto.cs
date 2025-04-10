namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class ListProductCategoryBannerResponseDto : PagingResponseDto
    {
      public  IEnumerable<ItemListProductCategoryBannerResponseDto> Items = Enumerable.Empty<ItemListProductCategoryBannerResponseDto>();
    }

    public class ItemListProductCategoryBannerResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
