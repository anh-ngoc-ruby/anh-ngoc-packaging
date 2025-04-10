namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class DetailProductViewComponent : BaseViewComponent
    {
        private readonly IGetProductUseCase useCase;
        public DetailProductViewComponent(IGetProductUseCase useCase)
        {
            this.useCase = useCase;
        }

        public async Task<IViewComponentResult> InvokeAsync(GetProductRequestDto param)
        {
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("Product","DetailProduct", data);
        }
    }
}
