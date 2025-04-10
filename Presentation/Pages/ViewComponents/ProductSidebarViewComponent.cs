namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class ProductSidebarViewComponent : BaseViewComponent
    {
        private readonly IGetListProductCategoryUseCase useCase;
        public ProductSidebarViewComponent(IGetListProductCategoryUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Sidebar", "ProductSidebar", data);
        }
    }
}
