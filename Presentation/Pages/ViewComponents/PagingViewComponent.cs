namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class PagingViewComponent : BaseViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PagingResponseDto paging)
        {
            return paging.Type switch
            {
                "product" => RenderViewComponent("Paging", "ProductPaging", paging),
                "blog" => RenderViewComponent("Paging", "BlogPaging", paging),
                _ => RenderViewComponent("Paging", "DefaultPaging", paging) 
            };


        }
    }
}
