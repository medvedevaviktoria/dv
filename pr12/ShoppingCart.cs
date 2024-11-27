using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Pr_12
{
    internal class ShoppingCart
    {
        public List<Product> products = new List<Product>();
        private int nextProductId = 1;

        public void AddProduct(Product product)
        {
            product.Id = nextProductId++;
            products.Add(product);
            Console.WriteLine($"\nТовар {product.Name} добавлен в корзину с id {product.Id}\n");
        }

        public string RemoveProduct(int id)
        {
            var productToRemove = products.Find(p => p.Id == id);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                return ($"Товар с id {id} удалён из корзины");
            }
            else
            {
                return ($"Товара с id {id} нет в корзине");
            }
        }

        




        public void  InfofCart()
        {
            double cost = 0;
            foreach (var product in products)
            {
                cost += product.Price * product.Quantity;


            }
            
        }


        //не нужно вообще
        //public string ListProducts()
        //{

        //    if (products.Count == 0)
        //    {
        //        return ("\nКорзина пуста.");
        //    }

            
        //    foreach (var product in products)
        //    {
                
        //        return (product.ShowInfo() + "\n");
        //    }
        //    return ("");
        //}
    }
}