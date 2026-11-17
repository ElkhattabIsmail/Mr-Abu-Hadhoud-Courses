using PizzaArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaArgs
{
    
        public class PizzaOrderEventArgs : EventArgs
        {
            public string Size { get; }
            public string Count { get; }
            public string TotalPrice { get; }


            public PizzaOrderEventArgs(string Size, string Count, string TotalPrice)
            {
                this.Size = Size;
                this.Count = Count;
                this.TotalPrice = TotalPrice;
            }

        
    }
}
//If multiple forms need to listen to the same event, you can use a static event in a separate class:

//public static class EventBroker
//{
//    public static event EventHandler<PizzaOrderEventArgs> OnPizzaOrderCreated;

//    public static void RaisePizzaOrder(string size, string count, string totalPrice)
//    {
//        OnPizzaOrderCreated?.Invoke(null, new PizzaOrderEventArgs(size, count, totalPrice));
//    }
//}