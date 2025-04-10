namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class BannerViewComponent : BaseViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(ItemListComponentResponseDto param)
        {
            return Task.FromResult(RenderViewComponent("Banner", param.FileName, param));
        }
    }
}
