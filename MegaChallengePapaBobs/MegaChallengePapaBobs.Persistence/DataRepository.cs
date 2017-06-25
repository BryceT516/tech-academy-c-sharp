using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaChallengePapaBobs.DTO;

namespace MegaChallengePapaBobs.Persistence
{
    public class DataRepository
    {
        public static List<DTO.PizzaOrder> GetOrders()
        {
            var ordersList = new List<DTO.PizzaOrder>();

            PapaBobsDataEntities db = new PapaBobsDataEntities();
            var dbOrders = db.Orders.Where(p=> p.Completed == false).ToList();

            foreach (var dbOrder in dbOrders)
            {
                var dtoOrder = new DTO.PizzaOrder();

                dtoOrder.OrderId = dbOrder.OrderId;
                dtoOrder.Name = dbOrder.Name;
                dtoOrder.Address = dbOrder.Address;
                dtoOrder.ZipCode = dbOrder.ZipCode;
                dtoOrder.Phone = dbOrder.Phone;
                dtoOrder.PaymentType = dbOrder.PaymentType;
                dtoOrder.Size = dbOrder.Size;
                dtoOrder.Crust = dbOrder.Crust;
                dtoOrder.Sausage = dbOrder.Sausage;
                dtoOrder.Pepperoni = dbOrder.Pepperoni;
                dtoOrder.Onions = dbOrder.Onions;
                dtoOrder.GreenPeppers = dbOrder.GreenPeppers;
                dtoOrder.TotalCost = dbOrder.TotalCost;
                dtoOrder.Completed = dbOrder.Completed;

                ordersList.Add(dtoOrder);

            }

            return ordersList;
        }

        public static void SaveOrder(PizzaOrder currentOrder)
        {
            PapaBobsDataEntities db = new PapaBobsDataEntities();
            var dbOrders = db.Orders;

            Order order = new Order();

            order.OrderId = currentOrder.OrderId;
            order.Name = currentOrder.Name;
            order.Address = currentOrder.Address;
            order.ZipCode = currentOrder.ZipCode;
            order.Phone = currentOrder.Phone;
            order.PaymentType = currentOrder.PaymentType;
            order.TotalCost = currentOrder.TotalCost;
            order.Size = currentOrder.Size;
            order.Crust = currentOrder.Crust;
            order.Sausage = currentOrder.Sausage;
            order.Pepperoni = currentOrder.Pepperoni;
            order.Onions = currentOrder.Onions;
            order.GreenPeppers = currentOrder.GreenPeppers;
            order.Completed = currentOrder.Completed;

            dbOrders.Add(order);

            db.SaveChanges();

        }

        public static void MarkOrderCompleted(Guid orderId)
        {
            PapaBobsDataEntities db = new PapaBobsDataEntities();
            db.Orders.Find(orderId).Completed = true;
            db.SaveChanges();
        }
    }


}
