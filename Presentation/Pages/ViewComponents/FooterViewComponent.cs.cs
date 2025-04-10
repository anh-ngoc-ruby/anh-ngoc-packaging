
namespace anh_ngoc_packaging.Presentation.Client.ViewComponents
{
    public class FooterViewComponent : BaseViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(LayoutResponseDto param)
        {
            return Task.FromResult(RenderViewComponent("Footer", "Footer", param));
        }
    }
}
