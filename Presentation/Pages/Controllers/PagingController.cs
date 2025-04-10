namespace anh_ngoc_packaging.Presentation.Pages.Controllers
{
    [Route("load-more")]
    public class PagingController : Controller
    {
        [HttpGet]
        [Route("products")]
        public IActionResult ProductPaging(GetListProductRequestDto param)
        {
            return ViewComponent("ListProductGrid", param);
        }
        [HttpGet]
        [Route("news")]
        public IActionResult NewsPaging()
        {
            return ViewComponent("NewsGrid2");
        }
    }
}
