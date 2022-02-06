using System;
using System.Collections.Generic;

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
        private List<Product> _products;

        public Order(StatusOrder status, List<Product> goodsInCart)
        {
            StatusOrder = status;
            _products = goodsInCart;
        }

        public StatusOrder StatusOrder { get; set; }
        public List<Product> FinalOrder
        {
            get
            {
                return _products;
            }

            private set
            {
                _products = FinalOrder;
            }
        }

        public string GetDetailsOfReceipt(List<Product> order)
        {
            Random rnd = new Random();
            int numberOfReceipt;
            numberOfReceipt = rnd.Next(1, 100);
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
