using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class Market
    {
        public event EventHandler<string> ProductAdded;
        private List<string> items;
        private List<Subscriber> subscribers;
        public Market()
        {
            items = new List<string>();
            subscribers = new List<Subscriber>();
        }
        public void Subscribe(Subscriber subscriber)
        {
            if (!subscribers.Contains(subscriber))
            {
                subscribers.Add(subscriber);
                ProductAdded += subscriber.UserAdded;
            }
        }
        public void UnSubscribe(Subscriber subscriber)
        {
            if (subscribers.Contains(subscriber))
            {
                subscribers.Remove(subscriber);
                ProductAdded -= subscriber.UserAdded;
            }
        }
        public void AddProduct(string product)
        {
            items.Add(product);
            Notify(product);
        }
        private void Notify(string product)
        {
            ProductAdded.Invoke(this, $"{product} has been added to our market");
        }
        // Know that the function take its  parameters from event invoking
    }
    public class  Subscriber
    {
        public string Name { get; }
        public Subscriber(string name)
        {
            Name = name;
        }
        public void UserAdded(object sender , string message)
        {
            Console.WriteLine($"{Name} received Notification : {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            /// when Invoke the event give him the parameters of the function he point 
            Subscriber subscriber1 = new Subscriber("   Ahmed");
            Subscriber subscriber2 = new Subscriber("  Ashraf");
            Subscriber subscriber3 = new Subscriber(" Elsaeed");
            Subscriber subscriber4 = new Subscriber("AbdelHai");
            market.Subscribe(subscriber1);
            market.Subscribe(subscriber2);
            market.Subscribe(subscriber3);
            market.Subscribe(subscriber4);
            market.AddProduct("Milk");
            Console.WriteLine("---------------------------------");
            market.UnSubscribe(subscriber4);
            market.AddProduct("Cheese");
        }
    }
}
