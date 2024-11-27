using Pr_11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Pr_11_Win
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonExitAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Length > 0) && (textBoxPrice.Text.Length > 0) && (textBoxCount.Text.Length > 0))
            {
                buttonAdd.Enabled = true;
            }
            else buttonAdd.Enabled = false;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8 || c == 32);
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;

        }
        Product newProduct;
       
        private void textBoxDeleteProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBoxDeleteProduct_TextChanged(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length > 0)
            {
                buttonDeleteProduct.Enabled = true;
            }
            else buttonDeleteProduct.Enabled = false;
        }

        private void buttonExitAdd_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ShoppingCart cart = new ShoppingCart();
        public int id;

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBoxID.Text);


            listBoxResult.Items.Add(cart.RemoveProduct(ID) + Environment.NewLine);
            textBoxID.Text = "";
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName.Text);
            double price = Convert.ToDouble(textBoxPrice.Text);
            int count = Convert.ToInt32(textBoxCount.Text);


            newProduct = new Product(name, price, count, id);

            cart.AddProduct(newProduct);
            listBoxResult.Items.Add(newProduct.ShowInfo() + Environment.NewLine);
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxCount.Text = "";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Add(cart.CostOfCart() + Environment.NewLine);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {


            listBoxResult.Items.Add("Список товаров: " + Environment.NewLine);

            if (cart.products.Count == 0)
            {
                listBoxResult.Items.Add("Корзина пуста." + Environment.NewLine);
            }
            foreach (var product in cart.products)
            {
                listBoxResult.Items.Add(product.ShowInfo() + Environment.NewLine);

            }
        }
    }
}
