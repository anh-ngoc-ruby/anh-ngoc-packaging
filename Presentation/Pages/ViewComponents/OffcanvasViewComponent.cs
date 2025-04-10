namespace anh_ngoc_packaging.Presentation.Client.ViewComponents
{
    public class OffcanvasViewComponent : BaseViewComponent
    {
        public  Task<IViewComponentResult> InvokeAsync(LayoutResponseDto param)
        {
            return Task.FromResult(RenderViewComponent("Offcanvas", "Offcanvas", param));
        }
    }
}
