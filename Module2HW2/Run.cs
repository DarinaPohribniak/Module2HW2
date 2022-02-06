using System;
using System.Collections.Generic;
using System.IO;

namespace Module2HW2
{
    public class Run
    {
        private Cart _cart;
        public void Runner()
        {
            Console.WriteLine("Items in our store:");
            ShowAllProducts(Store.GetAllProducts());
            Console.WriteLine();
            Store.FillCartRandomProducts(5);
            List<Product> myCart = Store.GetProducts();
            _cart = new Cart(myCart);
            ShowCart(myCart);
            ConfirmStatus();
            Order order = new Order(StatusOrder.InProgress, _cart.GoodsInCart);
            string detailsOfReceipt = order.GetDetailsOfReceipt(_cart.GoodsInCart);
            string reciept = string.Concat(detailsOfReceipt, ShowCart(order.FinalOrder));
            ExportToFile(reciept);
        }

        public void ChangeOrder()
        {
            Console.WriteLine();
            Console.WriteLine("To add a product press 1, to remove a product press 2");
            int numberOfAction;
            bool action = int.TryParse(Console.ReadLine(), out numberOfAction);
            if (action)
            {
                switch (numberOfAction)
                {
                    case 1:
                        {
                            _cart.AddProduct(2);
                            ConfirmStatus();
                            break;
                        }

                    case 2:
                        {
                            _cart.RemoveProduct(1);
                            ConfirmStatus();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

        public void ConfirmStatus()
        {
            string choiseStatus = "no";

            while (choiseStatus == "no")
            {
                Console.WriteLine("If you confirm your order, type 'yes' else type any value");
                choiseStatus = Console.ReadLine();
                if (choiseStatus == "yes")
                {
                    break;
                }

                ChangeOrder();
            }
        }

        public string ShowCart(List<Product> cart)
        {
            string str;
            string str1 = "This cart contains:\n";
            string str2 = null;
            foreach (var item in cart)
            {
                str2 = str2 + $"{item.Name}, price - {item.Price} $.\n";
            }

            string str3 = $"Total payment amount is {_cart.GetTotalSumm(cart)} $.\n";
            str = str1 + str2 + str3;
            Console.WriteLine(str);
            return str;
        }

        public void ShowAllProducts(List<Product> basket)
        {
            foreach (var item in basket)
            {
                Console.WriteLine($"ID {item.IDNumber}. Name of product -{item.Name}, price - {item.Price} $.");
            }
        }

        public void ExportToFile(string message)
        {
            File.WriteAllText("receipt.txt", message);
        }
    }
}