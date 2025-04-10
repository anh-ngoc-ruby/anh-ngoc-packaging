namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class BannerGridViewComponent : BaseViewComponent
    {
        private readonly IGetListProductCategoryBannerUseCase useCase;
        public BannerGridViewComponent(IGetListProductCategoryBannerUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync(ItemListComponentResponseDto param)
        {
            var data = await this.useCase.Execute();
            return RenderViewComponent("Banner", param.FileName, data);
        }
    }
}
