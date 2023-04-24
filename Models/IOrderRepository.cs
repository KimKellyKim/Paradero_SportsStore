using System.Linq;
using Paradero_SportsStore.Models;

namespace Paradero_SportsStore.Models
{
	public interface IOrderRepository
	{
		IQueryable<Order> Orders { get; }
		void SaveOrder(Order order);
	}
}