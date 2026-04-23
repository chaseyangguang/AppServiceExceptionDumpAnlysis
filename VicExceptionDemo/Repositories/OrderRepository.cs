using System.Linq;

namespace VicExceptionDemo.Repositories
{
    public class OrderRepository
    {
        public string GetLatestOrder()
        {
            var orders = new List<string>();

            // This will throw InvalidOperationException:
            // "Sequence contains no elements"
            return orders.First();
        }
    }
}
