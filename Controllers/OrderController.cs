using Microsoft.AspNetCore.Mvc;
using Paradero_SportsStore.Models;
namespace Paradero_SportsStore.Controllers
{
	public class OrderController : Controller
	{
		public ViewResult Checkout() => View(new Order());
	}
}