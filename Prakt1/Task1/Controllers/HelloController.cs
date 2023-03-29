using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
	public class HelloController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Result(User user)
		{
			return View(user);
		}

	}
}