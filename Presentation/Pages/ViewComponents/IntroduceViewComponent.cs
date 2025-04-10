namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class IntroduceViewComponent : BaseViewComponent
    {
        private readonly IGetIntroduceCompanyInfoUseCase useCase;
        public IntroduceViewComponent(IGetIntroduceCompanyInfoUseCase useCase)
        {
            this.useCase = useCase;
        }

        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Introduce", "Introduce", data);
        }
    }
}
