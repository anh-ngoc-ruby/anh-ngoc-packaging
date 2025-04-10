namespace anh_ngoc_packaging.Presentation.Client.ViewComponents
{
    public class HeaderMainViewComponent : BaseViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(LayoutResponseDto param)
        {
            return Task.FromResult(RenderViewComponent("Header", "HeaderMain", param));
        }
    }
}
