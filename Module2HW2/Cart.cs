using System;
using System.Collections.Generic;
using System.Linq;

namespace Module2HW2
{
    public class Cart
    {
        private List<Product> _goods = new List<Product>()
        {
            new Product(1, "apple", 1),
            new Product(2, "banana", 2),
            new Product(3, "chocolate", 3),
            new Product(4, "cola", 4),
            new Product(5, "rom", 5),
            new Product(6, "ice cream", 6),
            new Product(7, "cake", 7),
            new Product(8, "wother", 8),
            new Product(9, "vine", 9),
            new Product(10, "juice", 10),
        };

        private List<Product> _goodsInCart = new List<Product>();

        public Cart()
        {
        }

        public static List<Product> GoodsInCart { get; }

        public List<Product> GetAllProducts()
        {
            return _goods;
        }

        public List<Product> GetCart()
        {
            return _goodsInCart;
        }

        public void FillCartRandomProducts(int countOfProducts)
        {
            Console.WriteLine("User created the cart:");
            Random rnd = new Random();
            for (int i = 0; i < countOfProducts; i++)
            {
                int index = rnd.Next(0, _goods.Count - 1);
               /* Console.WriteLine($"{_goods[index].Name} - {_goods[index].Price} $.");*/
                _goodsInCart.Add(_goods[index]);
            }

            /*  GetTotalSumm(_goodsInCart);*/
        }

        public void AddProduct(int productId)
        {
            _goodsInCart.Add(_goods[productId]);
            Console.WriteLine($"User added {_goods[productId].Name}");
        }

        public void RemoveProduct(int productId)
        {
            if (_goodsInCart.Contains(_goods[productId]))
            {
                _goodsInCart.Remove(_goods[productId]);
                Console.WriteLine($"User removed {_goods[productId].Name}");
            }
            else
            {
                Console.WriteLine($"User didnt remove the product {_goods[productId].Name}, " +
                    $"it is not in the cart");
            }
        }

        public decimal GetTotalSumm(List<Product> goodsInCart)
        {
            Console.WriteLine();
            decimal totalSumm = goodsInCart.Sum(prs => prs.Price);
            return totalSumm;
        }
    }
}
