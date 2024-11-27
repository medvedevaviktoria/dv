using Pr_12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace pr12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product newProduct;
        ShoppingCart cart = new ShoppingCart();
        public int id;



        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !((c >= 'а' && c <= 'я') || c == 'ё' || c == 8 || c == 32);
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double itogSum = 0.0, itogSale = 0.0, inCassa = 0.0;

        private void buttonBuy_Click(object sender, EventArgs e)
        {

            // Получение текущей даты и времени
            DateTime now = DateTime.Now;

            // Форматирование даты и времени (можно изменить формат по желанию)
            string formattedDateTime = now.ToString("yyyy-MM-dd HH:mm:ss");
            // Путь к файлу 
            string filePath = "X:\\МДК 01.01\\pr12\\check.txt";

            try
            {
                // Создание объекта StreamWriter для записи в файл
                using (StreamWriter writer = new StreamWriter(filePath, true)) // true - дописывать в конец файла
                {
                    // Запись даты и времени в файл
                    writer.WriteLine(formattedDateTime);
                    writer.WriteLine("Сумма товаров: " + textBoxSum.Text + "\nСумма скидки: " + textBoxSale2.Text + "\nВ кассу: " + textBoxInCassa.Text);

                }
                MessageBox.Show("Вы купили товары!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка покупки товаров: " + ex.Message);
            }



            listBoxResult.Items.Clear();

            comboBoxName.SelectedIndex = 0;
            comboBoxPrice.SelectedIndex = 0;
            comboBoxSale.SelectedIndex = 0;
            numericUpDownCount.Value = 1;
            itogSum = 0.0;
            itogSale = 0.0;
            inCassa = 0.0;

            textBoxSum.Clear();
            textBoxSale2.Clear();
            textBoxInCassa.Clear();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxSum.Text.Length > 0) && (textBoxSale2.Text.Length > 0) && (textBoxInCassa.Text.Length > 0))
            {
                buttonBuy.Enabled = true;

            }
            else
            {
                buttonBuy.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string filePath = "X:\\МДК 01.01\\pr12\\products.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    comboBoxName.Items.Add(reader.ReadLine());
                    comboBoxPrice.Items.Add(reader.ReadLine());
                    comboBoxSale.Items.Add(reader.ReadLine());
                }
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBoxPrice.SelectedIndex = comboBoxName.SelectedIndex;
            comboBoxSale.SelectedIndex = comboBoxName.SelectedIndex;
            if ((comboBoxName.Text.Length > 0) && (comboBoxPrice.Text.Length > 0) && (comboBoxSale.Text.Length > 0))
            {
                buttonAdd.Enabled = true;

            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            comboBoxName.SelectedIndex = 0;
            comboBoxPrice.SelectedIndex = 0;
            comboBoxSale.SelectedIndex = 0;
            numericUpDownCount.Value = 1;
            itogSum = 0.0;
            itogSale = 0.0; 
            inCassa = 0.0;

            textBoxSum.Clear();
            textBoxSale2.Clear();
            textBoxInCassa.Clear();
        }

        public double p, d, s, ds, v, t, f;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            

            p = Convert.ToDouble(comboBoxPrice.Text);        //Цена
            d = Convert.ToDouble(comboBoxSale.Text);        //Скидка %



            newProduct = new Product(comboBoxName.Text, p, Convert.ToInt32(numericUpDownCount.Value), d, id);
            
            

            newProduct.InfoProduct(p, d);


            ds =newProduct.ds;                   //Величина скидки
            f = newProduct.f;                          //Цена со скидкой
            v = newProduct.v;                            //НДС
            t = newProduct.t;                      //Итоговая цена товара
                                                      //Вывод расчетов


            listBoxResult.Items.Add ("Товар: " + Environment.NewLine);
            listBoxResult.Items.Add ("Название: " + comboBoxName.Text + Environment.NewLine);
            listBoxResult.Items.Add( "Цена: " + p.ToString("0.00") +" руб." + Environment.NewLine);
            listBoxResult.Items.Add("Скидка: " + ds.ToString("0.00") + " руб." + Environment.NewLine);
            listBoxResult.Items.Add("Цена со скидкой: " + f.ToString("0.00") + " руб." + Environment.NewLine);
            listBoxResult.Items.Add("НДС (13%): " + v.ToString("0.00") + " руб." + Environment.NewLine);
            listBoxResult.Items.Add("Итого: " + t.ToString("0.00") + " руб." + Environment.NewLine);
            listBoxResult.Items.Add(Environment.NewLine);


            //вычисления в конце чека

            

            itogSum += p;
            itogSale += ds;
            inCassa += t;
            textBoxSum.Text = itogSum.ToString("0.00");
            textBoxSale2.Text = itogSale.ToString("0.00");
            textBoxInCassa.Text = inCassa.ToString("0.00");


            //очистка текстбоксов

            comboBoxName.SelectedIndex = 0;
            comboBoxPrice.SelectedIndex = 0;
            comboBoxSale.SelectedIndex = 0;
            numericUpDownCount.Value = 1;

        }
    }
}
