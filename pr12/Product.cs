using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_12
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        private double sale;
        private int id;
        public double ds, v, t, f;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price =  value; 
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public double Sale
        {
            get => sale;
            set => sale = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public Product(string name, double price, int quantity, double sale, int id)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Sale = sale;
            this.Id = id;
        }



        public void InfoProduct(double p, double d)
        {

            
            ds = p * (d / 100.0);                   //Величина скидки
            f = p - ds;                     //Цена со скидкой
            v = 0.13 * f;                       //НДС
            t = f + v;

            //return ($"Цена: {p}" + Environment.NewLine + $"Скидка: {d} " + Environment.NewLine + $"Величина скидки: {ds}" + Environment.NewLine + $"Цена со скидкой: {f} " + Environment.NewLine + $"НДС: {v} " + Environment.NewLine + $" Итого за товар: {t}" + Environment.NewLine);
        }





        //public string ShowInfo()
        //{


        //    return ($"Товар: {Name} Цена: {Price} Количество: {Quantity} ID товара: {Sale}");
        //}


    }
}