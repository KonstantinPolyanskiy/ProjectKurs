namespace FarmKurs.Views
{
    partial class TypeProductForm
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
            button1 = new Button();
            dataGridView_TypeProduct = new DataGridView();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button_ClearTypeProduct = new Button();
            button_AddTypeProduct = new Button();
            richTextBox_DescriptionTypeProduct = new RichTextBox();
            textBox_NameTypeProduct = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TypeProduct).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView_TypeProduct);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Все виды продукции";
            // 
            // button1
            // 
            button1.Location = new Point(140, 202);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 1;
            button1.Text = "Удалить тип продукта";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // dataGridView_TypeProduct
            // 
            dataGridView_TypeProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TypeProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_TypeProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TypeProduct.Location = new Point(6, 22);
            dataGridView_TypeProduct.MultiSelect = false;
            dataGridView_TypeProduct.Name = "dataGridView_TypeProduct";
            dataGridView_TypeProduct.RowTemplate.Height = 25;
            dataGridView_TypeProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_TypeProduct.Size = new Size(448, 174);
            dataGridView_TypeProduct.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button_ClearTypeProduct);
            groupBox2.Controls.Add(button_AddTypeProduct);
            groupBox2.Controls.Add(richTextBox_DescriptionTypeProduct);
            groupBox2.Controls.Add(textBox_NameTypeProduct);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить тип продукта";
            // 
            // button4
            // 
            button4.Location = new Point(66, 163);
            button4.Name = "button4";
            button4.Size = new Size(119, 23);
            button4.TabIndex = 6;
            button4.Text = "Вернуться назад";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button4_MouseClick;
            // 
            // button_ClearTypeProduct
            // 
            button_ClearTypeProduct.Location = new Point(140, 109);
            button_ClearTypeProduct.Name = "button_ClearTypeProduct";
            button_ClearTypeProduct.Size = new Size(103, 23);
            button_ClearTypeProduct.TabIndex = 5;
            button_ClearTypeProduct.Text = "Отмена";
            button_ClearTypeProduct.UseVisualStyleBackColor = true;
            button_ClearTypeProduct.MouseClick += button_ClearTypeProduct_MouseClick;
            // 
            // button_AddTypeProduct
            // 
            button_AddTypeProduct.Location = new Point(15, 109);
            button_AddTypeProduct.Name = "button_AddTypeProduct";
            button_AddTypeProduct.Size = new Size(103, 23);
            button_AddTypeProduct.TabIndex = 4;
            button_AddTypeProduct.Text = "Добавить";
            button_AddTypeProduct.UseVisualStyleBackColor = true;
            button_AddTypeProduct.MouseClick += button_AddTypeProduct_MouseClick;
            // 
            // richTextBox_DescriptionTypeProduct
            // 
            richTextBox_DescriptionTypeProduct.Location = new Point(249, 76);
            richTextBox_DescriptionTypeProduct.Name = "richTextBox_DescriptionTypeProduct";
            richTextBox_DescriptionTypeProduct.Size = new Size(205, 116);
            richTextBox_DescriptionTypeProduct.TabIndex = 3;
            richTextBox_DescriptionTypeProduct.Text = "";
            // 
            // textBox_NameTypeProduct
            // 
            textBox_NameTypeProduct.Location = new Point(249, 47);
            textBox_NameTypeProduct.Name = "textBox_NameTypeProduct";
            textBox_NameTypeProduct.Size = new Size(205, 23);
            textBox_NameTypeProduct.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(231, 15);
            label2.TabIndex = 1;
            label2.Text = "Описание типа выпускаемой продукции";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 50);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 0;
            label1.Text = "Название типа выпускаемой продукции";
            // 
            // TypeProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TypeProductForm";
            Text = "Типы продукции";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_TypeProduct).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private DataGridView dataGridView_TypeProduct;
        private GroupBox groupBox2;
        private Button button4;
        private Button button_ClearTypeProduct;
        private Button button_AddTypeProduct;
        private RichTextBox richTextBox_DescriptionTypeProduct;
        private TextBox textBox_NameTypeProduct;
        private Label label2;
        private Label label1;
    }
}