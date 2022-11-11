using Microsoft.AspNetCore.Mvc;

namespace TraverselCoreApplication.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
