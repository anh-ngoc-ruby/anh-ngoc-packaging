namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class LayoutResponseDto
    {
        public ListProductCategoryResponseDto ProductCategories { get; set; } = new ListProductCategoryResponseDto();
        public ListMenuResponseDto Menus { get; set; } = new ListMenuResponseDto();
        public CompanyContactResponseDto CompanyContact { get; set; } = new CompanyContactResponseDto();
        public CompanyInfoResponseDto CompanyInfo { get; set; } = new CompanyInfoResponseDto();
    }
}
