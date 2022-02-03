using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public enum StatusOrder
    {
        InProgress,
        Finished,
    }

    public class Order
    {
        private string _receipt;
        private List<Product> _finalOrder;

        public Order(StatusOrder status, List<Product> goodsInCart)
        {
            StatusOrder = status;
            _finalOrder = goodsInCart;
        }

        public string Reciept
        {
            get
            {
                return _receipt;
            }

            set
            {
                _receipt = Reciept;
            }
        }

        public StatusOrder StatusOrder { get; set; }
        public List<Product> FinalOrder
        {
            get
            {
                return _finalOrder;
            }

            private set
            {
                _finalOrder = FinalOrder;
            }
        }

        public string GetDetailsOfReceipt(List<Product> order)
        {
            Random rnd = new Random();
            int numberOfReceipt;
            numberOfReceipt = rnd.Next(1, 100);
            /*string message;*/
            if (order.Count != 0)
            {
                Console.WriteLine("Your order has been generated");
                Console.WriteLine();
                string str1 = $"RECEIPT  № {numberOfReceipt}\n";
                string str2 = $"Time and date of order: {DateTime.Now}\n";
                _receipt = str1 + str2;
                Console.WriteLine(_receipt);
                return _receipt;
            }
            else
            {
                _receipt = "Cart is empty, can't print receipt";
                Console.WriteLine(_receipt);
                return _receipt;
            }
        }
    }
}
