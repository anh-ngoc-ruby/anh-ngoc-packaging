namespace anh_ngoc_packaging.Shared.BaseController
{
    public abstract class BaseViewComponent : ViewComponent
    {
        private const string CLIENT_COMPONENT_PATH = "~/Views/Components/";
        protected IViewComponentResult RenderViewComponent<TModel>(string componentName, string fileName, TModel? model)
        {
            string viewPath = Path.Combine(CLIENT_COMPONENT_PATH, componentName, $"{fileName}.cshtml");
            return View(viewPath, model);
        }
        protected IViewComponentResult RenderViewComponent(string componentName, string fileName)
        {
            string viewPath = Path.Combine(CLIENT_COMPONENT_PATH, componentName, $"{fileName}.cshtml");
            return View(viewPath);
        }
    }
}
