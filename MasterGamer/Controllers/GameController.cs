using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace MasterGamer.Controllers
{
    [AllowAnonymous]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index(int p = 1)
        {
            var values = _gameService.TGetList().ToPagedList(p, 8);
            return View(values);
        }
    }
}
