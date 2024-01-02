using Microsoft.AspNetCore.Mvc;
namespace MasterGamer.ViewComponents.Default
{
    public class _Trailer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
