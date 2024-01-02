using Microsoft.AspNetCore.Mvc;
namespace MasterGamer.ViewComponents.Default
{
    public class _Newsletter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
