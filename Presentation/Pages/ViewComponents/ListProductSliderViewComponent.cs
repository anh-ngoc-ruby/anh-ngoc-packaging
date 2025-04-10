using System.ComponentModel;

namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class ListProductSliderViewComponent : BaseViewComponent
    {
        private readonly IGetListProductUseCase useCase;
        public ListProductSliderViewComponent(IGetListProductUseCase useCase)
        {
            this.useCase = useCase;
        }
        public async Task<IViewComponentResult> InvokeAsync(ItemListComponentResponseDto param)
        {
    
                var param1 = new GetListProductRequestDto
                {
                    CategorySlug = param.Extra["product_category_slug"] as string ?? ""
                };
            var file = param.Extra["file_name"] as string ?? "";
            var data = await this.useCase.Execute(param1);
            data.Component = param;
            return RenderViewComponent("Product", file, data);
        }
    }
}
