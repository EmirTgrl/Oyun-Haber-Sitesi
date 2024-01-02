using Microsoft.AspNetCore.Mvc;

namespace MasterGamer.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
