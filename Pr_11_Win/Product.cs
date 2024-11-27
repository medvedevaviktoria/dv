using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_11
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        private int id;


        public string Name
        {
            get { return (name != "") ? name : "Неизвестный товар"; }
            set { name = value.ToUpper(); }
        }

        public double Price
        {
            get => price;
            set { price = (value < 0.0) ? 0 : value; }
        }
        public int Quantity
        {
            get => quantity;
            set { quantity = (value < 0) ? 0 : value; }
        }

        public int Id
        {
            get => id;
            set => id = value;
        }


        public Product(string name, double price, int quantity, int id)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Id = id;
        }

        public string ShowInfo()
        {


            return ($"Товар: {Name} Цена: {Price} Количество: {Quantity} ID товара: {Id}");
        }


    }
}