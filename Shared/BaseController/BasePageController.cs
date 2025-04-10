namespace anh_ngoc_packaging.Shared.BaseController
{
    public abstract class BasePageController : Controller
    {
        private const string CLIENT_PAGE_PATH = "~/Views/Pages/";
        protected IActionResult RenderPageView<TModel>(string pageName, TModel? model)
        {
            string viewPath = Path.Combine(CLIENT_PAGE_PATH, $"{pageName}.cshtml");
            return View(viewPath, model);
        }

        protected IActionResult RenderPageView(string pageName)
        {
            string viewPath = Path.Combine(CLIENT_PAGE_PATH, $"{pageName}.cshtml");
            return View(viewPath);
        }
    }
}
