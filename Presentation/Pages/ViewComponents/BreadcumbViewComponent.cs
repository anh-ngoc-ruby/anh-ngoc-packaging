using System.Net.NetworkInformation;

namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class BreadcumbViewComponent : BaseViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string type)
        {

            return type switch
            {
                "product" => RenderViewComponent("Breadcumb", "ProductBreadcumb"),
                "blog" => RenderViewComponent("Breadcumb", "BlogBreadcumb"),
                "contact" => RenderViewComponent("Breadcumb", "ContactBreadcumb"),
                _ => RenderViewComponent("Breadcumb", "DefaultBreadcumb")
            };
        }
    }
}
