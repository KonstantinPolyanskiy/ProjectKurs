namespace FarmKurs.Views
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button_DeleteProduct = new Button();
            dataGridView_AddProducts = new DataGridView();
            groupBox2 = new GroupBox();
            textBoxSearch = new TextBox();
            button_ResetSearch = new Button();
            groupBox3 = new GroupBox();
            comboBoxLaboratories = new ComboBox();
            button_AddProduct = new Button();
            button_ClearProduct = new Button();
            comboBox_TypeProduct = new ComboBox();
            textBox_NameProduct = new TextBox();
            textBox_PriceProduct = new TextBox();
            textBox_CountProduct = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_ToNavigate = new Button();
            label6 = new Label();
            label_CountAllProducts = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AddProducts).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_DeleteProduct);
            groupBox1.Controls.Add(dataGridView_AddProducts);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вся продукция";
            // 
            // button_DeleteProduct
            // 
            button_DeleteProduct.Location = new Point(247, 330);
            button_DeleteProduct.Name = "button_DeleteProduct";
            button_DeleteProduct.Size = new Size(156, 23);
            button_DeleteProduct.TabIndex = 2;
            button_DeleteProduct.Text = "Удалить продукт";
            button_DeleteProduct.UseVisualStyleBackColor = true;
            button_DeleteProduct.MouseClick += button_DeleteProduct_MouseClick;
            // 
            // dataGridView_AddProducts
            // 
            dataGridView_AddProducts.AllowUserToAddRows = false;
            dataGridView_AddProducts.AllowUserToDeleteRows = false;
            dataGridView_AddProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AddProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_AddProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AddProducts.Location = new Point(6, 22);
            dataGridView_AddProducts.MultiSelect = false;
            dataGridView_AddProducts.Name = "dataGridView_AddProducts";
            dataGridView_AddProducts.ReadOnly = true;
            dataGridView_AddProducts.RowTemplate.Height = 25;
            dataGridView_AddProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AddProducts.Size = new Size(623, 300);
            dataGridView_AddProducts.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxSearch);
            groupBox2.Controls.Add(button_ResetSearch);
            groupBox2.Location = new Point(6, 359);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 61);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Отфильтровать";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(2, 31);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(534, 23);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // button_ResetSearch
            // 
            button_ResetSearch.Location = new Point(542, 31);
            button_ResetSearch.Name = "button_ResetSearch";
            button_ResetSearch.Size = new Size(75, 23);
            button_ResetSearch.TabIndex = 2;
            button_ResetSearch.Text = "Сбросить";
            button_ResetSearch.UseVisualStyleBackColor = true;
            button_ResetSearch.MouseClick += button_ResetSearch_MouseClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxLaboratories);
            groupBox3.Controls.Add(button_AddProduct);
            groupBox3.Controls.Add(button_ClearProduct);
            groupBox3.Controls.Add(comboBox_TypeProduct);
            groupBox3.Controls.Add(textBox_NameProduct);
            groupBox3.Controls.Add(textBox_PriceProduct);
            groupBox3.Controls.Add(textBox_CountProduct);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(653, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 322);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Добавить продукт";
            // 
            // comboBoxLaboratories
            // 
            comboBoxLaboratories.FormattingEnabled = true;
            comboBoxLaboratories.Location = new Point(158, 250);
            comboBoxLaboratories.Name = "comboBoxLaboratories";
            comboBoxLaboratories.Size = new Size(212, 23);
            comboBoxLaboratories.TabIndex = 13;
            // 
            // button_AddProduct
            // 
            button_AddProduct.Location = new Point(44, 293);
            button_AddProduct.Name = "button_AddProduct";
            button_AddProduct.Size = new Size(130, 23);
            button_AddProduct.TabIndex = 12;
            button_AddProduct.Text = "Добавить продукт";
            button_AddProduct.UseVisualStyleBackColor = true;
            button_AddProduct.MouseClick += button_AddProduct_MouseClick;
            // 
            // button_ClearProduct
            // 
            button_ClearProduct.Location = new Point(208, 293);
            button_ClearProduct.Name = "button_ClearProduct";
            button_ClearProduct.Size = new Size(110, 23);
            button_ClearProduct.TabIndex = 11;
            button_ClearProduct.Text = "Отмена";
            button_ClearProduct.UseVisualStyleBackColor = true;
            button_ClearProduct.MouseClick += button_ClearProduct_MouseClick;
            // 
            // comboBox_TypeProduct
            // 
            comboBox_TypeProduct.FormattingEnabled = true;
            comboBox_TypeProduct.Location = new Point(158, 150);
            comboBox_TypeProduct.Name = "comboBox_TypeProduct";
            comboBox_TypeProduct.Size = new Size(212, 23);
            comboBox_TypeProduct.TabIndex = 8;
            // 
            // textBox_NameProduct
            // 
            textBox_NameProduct.Location = new Point(158, 200);
            textBox_NameProduct.Name = "textBox_NameProduct";
            textBox_NameProduct.Size = new Size(212, 23);
            textBox_NameProduct.TabIndex = 7;
            // 
            // textBox_PriceProduct
            // 
            textBox_PriceProduct.Location = new Point(158, 100);
            textBox_PriceProduct.Name = "textBox_PriceProduct";
            textBox_PriceProduct.Size = new Size(212, 23);
            textBox_PriceProduct.TabIndex = 6;
            // 
            // textBox_CountProduct
            // 
            textBox_CountProduct.Location = new Point(158, 50);
            textBox_CountProduct.Name = "textBox_CountProduct";
            textBox_CountProduct.Size = new Size(212, 23);
            textBox_CountProduct.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 253);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "Лаборатория";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 203);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 3;
            label4.Text = "Название продукта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 153);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Тип продукта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 103);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Стоимость (шт.)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество продукции";
            // 
            // button_ToNavigate
            // 
            button_ToNavigate.Location = new Point(861, 402);
            button_ToNavigate.Name = "button_ToNavigate";
            button_ToNavigate.Size = new Size(110, 23);
            button_ToNavigate.TabIndex = 13;
            button_ToNavigate.Text = "Вернуться назад";
            button_ToNavigate.UseVisualStyleBackColor = true;
            button_ToNavigate.MouseClick += button_ToNavigate_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(659, 34);
            label6.Name = "label6";
            label6.Size = new Size(251, 15);
            label6.TabIndex = 14;
            label6.Text = "Количество всей произведенной продукции";
            // 
            // label_CountAllProducts
            // 
            label_CountAllProducts.AutoSize = true;
            label_CountAllProducts.Location = new Point(953, 34);
            label_CountAllProducts.Name = "label_CountAllProducts";
            label_CountAllProducts.Size = new Size(25, 15);
            label_CountAllProducts.TabIndex = 15;
            label_CountAllProducts.Text = "999";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(label_CountAllProducts);
            Controls.Add(label6);
            Controls.Add(button_ToNavigate);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ProductsForm";
            Text = "Продукция";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AddProducts).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_DeleteProduct;
        private DataGridView dataGridView_AddProducts;
        private GroupBox groupBox2;
        private Button button_ResetSearch;
        private GroupBox groupBox3;
        private Button button_AddProduct;
        private Button button_ClearProduct;
        private ComboBox comboBox_TypeProduct;
        private TextBox textBox_NameProduct;
        private TextBox textBox_PriceProduct;
        private TextBox textBox_CountProduct;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_ToNavigate;
        private Label label6;
        private Label label_CountAllProducts;
        private TextBox textBoxSearch;
        private ComboBox comboBoxLaboratories;
    }
}