using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrderEvents
{
    public class OrderEventArrge : EventArgs
    {
        public int OrderID { set; get; }
        public int OrderTotalPrice { set; get; }
        public string ClientEmail { set; get; }

        public OrderEventArrge(int OrderID, int OrderTotalPrice, string ClientEmail)
        {
            this.OrderID = OrderID;
            this.OrderTotalPrice = OrderTotalPrice;
            this.ClientEmail = ClientEmail;
        }
    }

    public class Order
    {
        public event EventHandler<OrderEventArrge> OnOrderCreated;

        public void Created(int OrderID, int OrderTotalPrice, string ClientEmail)
        {
            Console.WriteLine("New Order created, Now will notify everyOne by raising the event.\n");
            if (OnOrderCreated != null)
            {
                OnOrderCreated(this, new OrderEventArrge(OrderID, OrderTotalPrice, ClientEmail));
            }
           
        }
    }

    public class EmailService
    {

        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNeworder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNeworder;
        }
        public void HandleNeworder(object sender, OrderEventArrge e)
        {
            Console.WriteLine("-----------------------Email Service-----------------------");
            Console.WriteLine("sms Service object Recieced a new order event.");
            Console.WriteLine("Order ID : " + e.OrderID);
            Console.WriteLine("order Price : " + e.OrderTotalPrice );
            Console.WriteLine("Email : " + e.ClientEmail);
            Console.WriteLine("send an Email");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine();
        }
    }
    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNeworder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNeworder;
        }
        public void HandleNeworder(object sender, OrderEventArrge e)
        {
            Console.WriteLine("-----------------------SMS Service-----------------------");
            Console.WriteLine("sms Service object Recieced a new order event.");
            Console.WriteLine("Order ID : " + e.OrderID);
            Console.WriteLine("order Price : " + e.OrderTotalPrice);
            Console.WriteLine("Email : " + e.ClientEmail);
            Console.WriteLine("send an Email");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine();
        }
    }
    public class ShipingService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNeworder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNeworder;
        }
        public void HandleNeworder(object sender, OrderEventArrge e)
        {
            Console.WriteLine("-----------------------Shiping Service-----------------------");
            Console.WriteLine("sms Service object Recieced a new order event.");
            Console.WriteLine("Order ID : " + e.OrderID);
            Console.WriteLine("order Price : " + e.OrderTotalPrice);
            Console.WriteLine("Email : " + e.ClientEmail);
            Console.WriteLine("send an Email");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            EmailService EmailService = new EmailService();
            EmailService.Subscribe(order);

            SMSService SMSService = new SMSService();
            SMSService.Subscribe(order);

            ShipingService ShipingService = new ShipingService();
            ShipingService.Subscribe(order);

            order.Created(1, 1200, "saddamalzekri33@gmail.com");
            EmailService.UnSubscribe(order);
            order.Created(2, 2200, "AbujamraAlzekri@gmail.com");

            Console.ReadKey();
        }
    }

}
