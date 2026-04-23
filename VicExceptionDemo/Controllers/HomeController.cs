using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VicExceptionDemo.Models;
using VicExceptionDemo.Services;

namespace VicExceptionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderService _orderService;

        public HomeController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            // Exception is not thrown here directly.
            // It happens in a lower layer.
            var result = _orderService.GetLatestOrderName();

            return Content(result);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
