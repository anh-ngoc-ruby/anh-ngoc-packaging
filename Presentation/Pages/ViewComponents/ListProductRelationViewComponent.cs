using System.ComponentModel;

namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class ListProductRelationViewComponent : BaseViewComponent
    {
        private readonly IGetListProductRelationUseCase useCase;
        public ListProductRelationViewComponent(IGetListProductRelationUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync(GetListProductRelationRequestDto param)
        {
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("Product", "ProductType7", data);
        }
    }
}
