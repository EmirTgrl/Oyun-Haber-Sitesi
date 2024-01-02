using Microsoft.AspNetCore.Mvc;

namespace MasterGamer.ViewComponents.Default
{
    public class _Featured : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
