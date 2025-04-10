namespace anh_ngoc_packaging.Presentation.Pages.Controllers
{
    public class PageController : BasePageController
    {
        private readonly IGetListComponentUseCase getListComponentUseCase;
        public PageController(IGetListComponentUseCase getListComponentUseCase)
        {
            this.getListComponentUseCase = getListComponentUseCase;
        }

        [HttpGet, ActionName("GetHomePage")]
        public async Task<IActionResult> GetHomePage()
        {
            var data = await this.getListComponentUseCase.Execute();
            return RenderPageView("Index", data);
        }


        [HttpGet, ActionName("GetIntroducePage")]
        [Route("gioi-thieu")]
        public IActionResult GetIntroducePage()
        {
            return RenderPageView("Introduce");
        }


        [HttpGet, ActionName("GetListProductPage")]
        [Route("san-pham")]
        public IActionResult GetListProductPage(GetListProductRequestDto param)
        {
            return RenderPageView("Product", param);
        }

        [HttpGet, ActionName("GetDetailProductPage")]
        [Route("san-pham/{slug?}")]
        public IActionResult GetDetailProductPage(GetProductRequestDto param)
        {
            return RenderPageView("DetailProduct", param);
        }

        //[HttpGet, ActionName("GetListBlogPage")]
        //[Route("bai-viet")]
        //public IActionResult GetListBlogPage()
        //{
        //    return RenderPageView("ListBlog");
        //}

        //[HttpGet, ActionName("GetDetailBlogPage")]
        //[Route("bai-viet/{slug}")]
        //public IActionResult GetDetailBlogPage()
        //{
        //    return RenderPageView("DetailBlog");
        //}

        [HttpGet, ActionName("GetContactPage")]
        [Route("lien-he")]
        public IActionResult GetContactPage()
        {
            return RenderPageView("Contact");
        }


    }
}
