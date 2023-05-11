using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Unit32_MVC.Repositories;

namespace Unit32_MVC.Controllers
{
    public class LogsController : Controller
    {
        private readonly IRequestRepository _repo;

        public LogsController(IRequestRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Метод, возвращающий страницу с историей запросов
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var logs = await _repo.GetRequests();
            return View(logs);
        }
    }
}
