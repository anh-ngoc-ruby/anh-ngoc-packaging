namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class PolicyViewComponent : BaseViewComponent
    {
        private readonly IGetListPolicyUseCase useCase;
        public PolicyViewComponent(IGetListPolicyUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Policy", "Policy", data);
        }
    }
}
