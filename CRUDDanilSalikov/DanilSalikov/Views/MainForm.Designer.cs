namespace DanilSalikov
{
    partial class MainForm
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
            DataGridViewDoors = new DataGridView();
            ButtonAddDoor = new Button();
            ButtonEditDoor = new Button();
            ButtonDeleteDoor = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            TextBoxSearch = new TextBox();
            ButtonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDoors).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewDoors
            // 
            DataGridViewDoors.AllowUserToAddRows = false;
            DataGridViewDoors.AllowUserToDeleteRows = false;
            DataGridViewDoors.AllowUserToResizeColumns = false;
            DataGridViewDoors.AllowUserToResizeRows = false;
            DataGridViewDoors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewDoors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewDoors.BackgroundColor = SystemColors.ControlLightLight;
            DataGridViewDoors.Dock = DockStyle.Top;
            DataGridViewDoors.GridColor = SystemColors.Window;
            DataGridViewDoors.Location = new Point(0, 0);
            DataGridViewDoors.MultiSelect = false;
            DataGridViewDoors.Name = "DataGridViewDoors";
            DataGridViewDoors.RowTemplate.Height = 25;
            DataGridViewDoors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewDoors.Size = new Size(1085, 396);
            DataGridViewDoors.TabIndex = 0;
            // 
            // ButtonAddDoor
            // 
            ButtonAddDoor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddDoor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddDoor.Location = new Point(366, 504);
            ButtonAddDoor.Name = "ButtonAddDoor";
            ButtonAddDoor.Size = new Size(91, 30);
            ButtonAddDoor.TabIndex = 1;
            ButtonAddDoor.Text = "Добавить";
            ButtonAddDoor.UseVisualStyleBackColor = true;
            ButtonAddDoor.MouseClick += ButtonAddDoor_MouseClick;
            // 
            // ButtonEditDoor
            // 
            ButtonEditDoor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonEditDoor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEditDoor.Location = new Point(477, 504);
            ButtonEditDoor.Name = "ButtonEditDoor";
            ButtonEditDoor.Size = new Size(144, 30);
            ButtonEditDoor.TabIndex = 2;
            ButtonEditDoor.Text = "Редактировать";
            ButtonEditDoor.UseVisualStyleBackColor = true;
            ButtonEditDoor.MouseClick += ButtonEditDoor_MouseClick;
            // 
            // ButtonDeleteDoor
            // 
            ButtonDeleteDoor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonDeleteDoor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDeleteDoor.Location = new Point(641, 504);
            ButtonDeleteDoor.Name = "ButtonDeleteDoor";
            ButtonDeleteDoor.Size = new Size(91, 30);
            ButtonDeleteDoor.TabIndex = 3;
            ButtonDeleteDoor.Text = "Удалить";
            ButtonDeleteDoor.UseVisualStyleBackColor = true;
            ButtonDeleteDoor.MouseClick += ButtonDeleteDoor_MouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 421);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 140);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление записей";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(22, 99);
            button3.Name = "button3";
            button3.Size = new Size(249, 23);
            button3.TabIndex = 2;
            button3.Text = "Категория";
            button3.UseVisualStyleBackColor = true;
            button3.MouseClick += button3_MouseClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(22, 70);
            button2.Name = "button2";
            button2.Size = new Size(249, 23);
            button2.TabIndex = 1;
            button2.Text = "Производитель";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(22, 43);
            button1.Name = "button1";
            button1.Size = new Size(249, 23);
            button1.TabIndex = 0;
            button1.Text = "Материал";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(759, 421);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 140);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр записей";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(23, 99);
            button4.Name = "button4";
            button4.Size = new Size(249, 23);
            button4.TabIndex = 5;
            button4.Text = "Категории";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button4_MouseClick;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(23, 43);
            button6.Name = "button6";
            button6.Size = new Size(249, 23);
            button6.TabIndex = 3;
            button6.Text = "Материалы";
            button6.UseVisualStyleBackColor = true;
            button6.MouseClick += button6_MouseClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(23, 70);
            button5.Name = "button5";
            button5.Size = new Size(249, 23);
            button5.TabIndex = 4;
            button5.Text = "Производители";
            button5.UseVisualStyleBackColor = true;
            button5.MouseClick += button5_MouseClick;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(366, 456);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(285, 23);
            TextBoxSearch.TabIndex = 6;
            TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(657, 456);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(75, 23);
            ButtonClear.TabIndex = 7;
            ButtonClear.Text = "Сбросить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.MouseClick += ButtonClear_MouseClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 573);
            Controls.Add(ButtonClear);
            Controls.Add(TextBoxSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ButtonDeleteDoor);
            Controls.Add(ButtonEditDoor);
            Controls.Add(ButtonAddDoor);
            Controls.Add(DataGridViewDoors);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог дверей";
            ((System.ComponentModel.ISupportInitialize)DataGridViewDoors).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewDoors;
        private Button ButtonAddDoor;
        private Button ButtonEditDoor;
        private Button ButtonDeleteDoor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button6;
        private Button button5;
        private TextBox TextBoxSearch;
        private Button ButtonClear;
    }
}