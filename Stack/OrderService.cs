using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class OrderService
    {
        private readonly IStorage _storage;
        public OrderService(IStorage storage)
        {
            _storage = storage;
        }
        public int PlaceOrder(Order order)
        {
            
            try
            {
                    return _storage.Store(order) * 3;;
            }
            catch (ArgumentException ex)
            {
                return -1;
                
            }

        }
    }
    public class Order
    {
    }
    public interface IStorage
    {
        int Store(Order order);
        Order Exists(int id);
    }
}
