namespace anh_ngoc_packaging.Presentation.Client.ViewComponents
{
    public class ContactMapsViewComponent : BaseViewComponent
    {
        public ContactMapsViewComponent()
        {
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult(RenderViewComponent("Contact", "ContactMaps"));
        }
    }
}
