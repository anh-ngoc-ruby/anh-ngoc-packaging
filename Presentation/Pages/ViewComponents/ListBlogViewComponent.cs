namespace anh_ngoc_packaging.Presentation.Pages.ViewComponents
{
    public class ListBlogViewComponent : BaseViewComponent
    {
        private readonly IGetListBlogUseCase useCase;

        public ListBlogViewComponent(IGetListBlogUseCase useCase)
        {
            this.useCase = useCase;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var param = new GetListBlogRequestDto
            {
                PageSize = 4
            };
            var data = await this.useCase.Execute(param);
            return RenderViewComponent("Blog", "BlogGrid", data);
        }
    }
}
