namespace Pr_11_Win
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelWriteCount = new System.Windows.Forms.Label();
            this.labelWritePrice = new System.Windows.Forms.Label();
            this.labelWriteName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.labelDeletPrduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите, что вы хотите сделать:";
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(19, 272);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(172, 46);
            this.buttonSum.TabIndex = 3;
            this.buttonSum.Text = "Посчитать общую стоимость корзины";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(378, 278);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(172, 40);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Показать список товаров в корзине";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(591, 528);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(122, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(12, 341);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(538, 212);
            this.listBoxResult.TabIndex = 16;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(179, 124);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(192, 20);
            this.textBoxCount.TabIndex = 15;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(163, 92);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(208, 20);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(163, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 20);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelWriteCount
            // 
            this.labelWriteCount.AutoSize = true;
            this.labelWriteCount.Location = new System.Drawing.Point(16, 124);
            this.labelWriteCount.Name = "labelWriteCount";
            this.labelWriteCount.Size = new System.Drawing.Size(157, 13);
            this.labelWriteCount.TabIndex = 12;
            this.labelWriteCount.Text = "Введите количество товаров:";
            // 
            // labelWritePrice
            // 
            this.labelWritePrice.AutoSize = true;
            this.labelWritePrice.Location = new System.Drawing.Point(16, 92);
            this.labelWritePrice.Name = "labelWritePrice";
            this.labelWritePrice.Size = new System.Drawing.Size(116, 13);
            this.labelWritePrice.TabIndex = 11;
            this.labelWritePrice.Text = "Введите цену товара:";
            // 
            // labelWriteName
            // 
            this.labelWriteName.AutoSize = true;
            this.labelWriteName.Location = new System.Drawing.Point(16, 60);
            this.labelWriteName.Name = "labelWriteName";
            this.labelWriteName.Size = new System.Drawing.Size(141, 13);
            this.labelWriteName.TabIndex = 10;
            this.labelWriteName.Text = "Введите название товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Добавить товар в корзину";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(480, 89);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 21;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxDeleteProduct_TextChanged);
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeleteProduct_KeyPress);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Enabled = false;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(490, 124);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 20;
            this.buttonDeleteProduct.Text = "Удалить";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // labelDeletPrduct
            // 
            this.labelDeletPrduct.AutoSize = true;
            this.labelDeletPrduct.Location = new System.Drawing.Point(396, 57);
            this.labelDeletPrduct.Name = "labelDeletPrduct";
            this.labelDeletPrduct.Size = new System.Drawing.Size(291, 13);
            this.labelDeletPrduct.TabIndex = 19;
            this.labelDeletPrduct.Text = "Введите id товара, который хотите удалить из корзины:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(451, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Удалить товар из корзины";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.labelDeletPrduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelWriteCount);
            this.Controls.Add(this.labelWritePrice);
            this.Controls.Add(this.labelWriteName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Магазин товаров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelWriteCount;
        private System.Windows.Forms.Label labelWritePrice;
        private System.Windows.Forms.Label labelWriteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Label labelDeletPrduct;
        private System.Windows.Forms.Label label3;
    }
}

