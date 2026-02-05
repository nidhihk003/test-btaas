using DummyApp.Models;

namespace DummyApp.Services
{
    public class OrderService
    {
        public Order CreateOrder(int id)
        {
            return new Order { Id = id, Status = "Created" };
        }
    }
}
