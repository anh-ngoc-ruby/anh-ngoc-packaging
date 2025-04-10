namespace anh_ngoc_packaging.Presentation.Client.ViewComponents
{
    public class ContactFormViewComponent : BaseViewComponent
    {
        private readonly IGetCompanyInfoUseCase useCase;
        public ContactFormViewComponent(IGetCompanyInfoUseCase useCase)
        {
            this.useCase = useCase;
        }

        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Contact", "ContactForm", data);
        }
    }
}
