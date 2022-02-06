using System;
using System.Collections.Generic;

namespace Module2HW2
{
    public static class Store
    {
        private static List<Product> goods = new List<Product>()
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

        private static List<Product> goodsInCart = new List<Product>();

        public static List<Product> GetAllProducts()
        {
            return goods;
        }

        public static Product GetProduct(int productId)
        {
            foreach (var item in goods)
            {
                if (item.IDNumber == productId)
                {
                    return item;
                }
            }

            return null;
        }

        public static List<Product> GetProducts()
        {
            return goodsInCart;
        }

        public static void FillCartRandomProducts(int countOfProducts)
        {
            Console.WriteLine("User created the cart:");
            Random rnd = new Random();
            for (int i = 0; i < countOfProducts; i++)
            {
                int index = rnd.Next(0, goods.Count - 1);
                goodsInCart.Add(goods[index]);
                Console.WriteLine(goods[index].Name);
            }
        }
    }
}
