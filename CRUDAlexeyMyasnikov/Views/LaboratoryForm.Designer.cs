namespace FarmKurs.Views
{
    partial class LaboratoryForm
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
            button_DeleteLab = new Button();
            dataGridView_AllLab = new DataGridView();
            groupBox2 = new GroupBox();
            button_ClearLab = new Button();
            button_AddLab = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox_EmployeeStaff = new ComboBox();
            label_11 = new Label();
            button_ToNavigate = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AllLab).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_DeleteLab);
            groupBox1.Controls.Add(dataGridView_AllLab);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Все лаборатории";
            // 
            // button_DeleteLab
            // 
            button_DeleteLab.Location = new Point(178, 389);
            button_DeleteLab.Name = "button_DeleteLab";
            button_DeleteLab.Size = new Size(173, 24);
            button_DeleteLab.TabIndex = 1;
            button_DeleteLab.Text = "Удалить лабораборию";
            button_DeleteLab.UseVisualStyleBackColor = true;
            button_DeleteLab.MouseClick += button_DeleteLab_MouseClick;
            // 
            // dataGridView_AllLab
            // 
            dataGridView_AllLab.AllowUserToAddRows = false;
            dataGridView_AllLab.AllowUserToDeleteRows = false;
            dataGridView_AllLab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AllLab.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_AllLab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AllLab.Location = new Point(6, 22);
            dataGridView_AllLab.MultiSelect = false;
            dataGridView_AllLab.Name = "dataGridView_AllLab";
            dataGridView_AllLab.ReadOnly = true;
            dataGridView_AllLab.RowTemplate.Height = 25;
            dataGridView_AllLab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AllLab.Size = new Size(518, 361);
            dataGridView_AllLab.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_ClearLab);
            groupBox2.Controls.Add(button_AddLab);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(comboBox_EmployeeStaff);
            groupBox2.Controls.Add(label_11);
            groupBox2.Location = new Point(548, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 293);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить лабораторию";
            // 
            // button_ClearLab
            // 
            button_ClearLab.Location = new Point(263, 238);
            button_ClearLab.Name = "button_ClearLab";
            button_ClearLab.Size = new Size(75, 23);
            button_ClearLab.TabIndex = 11;
            button_ClearLab.Text = "Отмена";
            button_ClearLab.UseVisualStyleBackColor = true;
            button_ClearLab.MouseClick += button_ClearLab_MouseClick;
            // 
            // button_AddLab
            // 
            button_AddLab.Location = new Point(17, 238);
            button_AddLab.Name = "button_AddLab";
            button_AddLab.Size = new Size(229, 23);
            button_AddLab.TabIndex = 10;
            button_AddLab.Text = "Добавить лабораторию";
            button_AddLab.UseVisualStyleBackColor = true;
            button_AddLab.MouseClick += button_AddLab_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 168);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 9;
            label4.Text = "Используемое сырье";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 118);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 7;
            label3.Text = "Производительность лаб.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox_EmployeeStaff
            // 
            comboBox_EmployeeStaff.FormattingEnabled = true;
            comboBox_EmployeeStaff.Location = new Point(159, 65);
            comboBox_EmployeeStaff.Name = "comboBox_EmployeeStaff";
            comboBox_EmployeeStaff.Size = new Size(179, 23);
            comboBox_EmployeeStaff.TabIndex = 5;
            // 
            // label_11
            // 
            label_11.AutoSize = true;
            label_11.Location = new Point(44, 68);
            label_11.Name = "label_11";
            label_11.Size = new Size(109, 15);
            label_11.TabIndex = 4;
            label_11.Text = "Штаб сотрудников";
            // 
            // button_ToNavigate
            // 
            button_ToNavigate.Location = new Point(673, 352);
            button_ToNavigate.Name = "button_ToNavigate";
            button_ToNavigate.Size = new Size(156, 43);
            button_ToNavigate.TabIndex = 2;
            button_ToNavigate.Text = "Вернуться назад";
            button_ToNavigate.UseVisualStyleBackColor = true;
            button_ToNavigate.MouseClick += button_ToNavigate_MouseClick;
            // 
            // LaboratoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(button_ToNavigate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LaboratoryForm";
            Text = "Лаборатории";
            Load += LaboratoryForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AllLab).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_DeleteLab;
        private DataGridView dataGridView_AllLab;
        private GroupBox groupBox2;
        private Button button_ClearLab;
        private Button button_AddLab;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox_EmployeeStaff;
        private Label label_11;
        private Button button_ToNavigate;
    }
}