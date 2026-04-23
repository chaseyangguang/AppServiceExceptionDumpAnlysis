using VicExceptionDemo.Repositories;

namespace VicExceptionDemo.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public string GetLatestOrderName()
        {
            var order = _orderRepository.GetLatestOrder();
            return $"Latest order: {order}";
        }
    }
}
