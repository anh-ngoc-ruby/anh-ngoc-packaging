namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class ListProductGridViewComponent : BaseViewComponent
    {
        private readonly IGetListProductUseCase useCase;
        public ListProductGridViewComponent(IGetListProductUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync(GetListProductRequestDto param)
        {
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("Product", "ProductGrid", data);
        }
    }
}
