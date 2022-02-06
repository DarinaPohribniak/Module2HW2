using System;
using System.Collections.Generic;
using System.Linq;

namespace Module2HW2
{
    public class Cart
    {
        private List<Product> _goodsInCart = new List<Product>();

        public Cart(List<Product> products)
        {
            _goodsInCart = products;
        }

        public List<Product> GoodsInCart
        {
            get
            {
                return _goodsInCart;
            }
        }

        public void AddProduct(int productId)
        {
            _goodsInCart.Add(Store.GetProduct(productId));
            Console.WriteLine($"User added {Store.GetProduct(productId).Name}");
        }

        public void RemoveProduct(int productId)
        {
            if (_goodsInCart.Contains(Store.GetProduct(productId)))
            {
                _goodsInCart.Remove(Store.GetProduct(productId));
                Console.WriteLine($"User removed {Store.GetProduct(productId).Name}");
            }
            else
            {
                Console.WriteLine($"User didnt remove the product {Store.GetProduct(productId).Name}, " +
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
