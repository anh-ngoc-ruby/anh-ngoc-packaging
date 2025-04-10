namespace anh_ngoc_packaging.Presentation.Client.ViewComponents
{
    public class HeaderStickyViewComponent : BaseViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(LayoutResponseDto param)
        {
            return Task.FromResult(RenderViewComponent("Header", "HeaderSticky", param));
        }
    }
}
