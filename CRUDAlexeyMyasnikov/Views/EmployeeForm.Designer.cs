namespace FarmKurs.Views
{
    partial class EmployeeForm
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
            groupBox3 = new GroupBox();
            comboBoxManagerEmployeer = new ComboBox();
            button_CancelStaffEmployee = new Button();
            button_AddStaffEmployee = new Button();
            listBox_Employes = new ListBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button_DeleteStaffEmployee = new Button();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            button_ToNavigate = new Button();
            groupBox6 = new GroupBox();
            button_ClearEmployee = new Button();
            button_AddEmployee = new Button();
            textBox_SalaryEmployee = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox_EmployeePosition = new TextBox();
            textBox_NameEmployer = new TextBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            button_DeleteEmployee = new Button();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(9, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Штаб сотрудников";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxManagerEmployeer);
            groupBox3.Controls.Add(button_CancelStaffEmployee);
            groupBox3.Controls.Add(button_AddStaffEmployee);
            groupBox3.Controls.Add(listBox_Employes);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(6, 263);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(485, 159);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Добавить штаб";
            // 
            // comboBoxManagerEmployeer
            // 
            comboBoxManagerEmployeer.FormattingEnabled = true;
            comboBoxManagerEmployeer.Location = new Point(180, 39);
            comboBoxManagerEmployeer.Name = "comboBoxManagerEmployeer";
            comboBoxManagerEmployeer.Size = new Size(203, 23);
            comboBoxManagerEmployeer.TabIndex = 8;
            // 
            // button_CancelStaffEmployee
            // 
            button_CancelStaffEmployee.Location = new Point(389, 86);
            button_CancelStaffEmployee.Name = "button_CancelStaffEmployee";
            button_CancelStaffEmployee.Size = new Size(75, 23);
            button_CancelStaffEmployee.TabIndex = 7;
            button_CancelStaffEmployee.Text = "Отмена";
            button_CancelStaffEmployee.UseVisualStyleBackColor = true;
            button_CancelStaffEmployee.MouseClick += button_CancelStaffEmployee_MouseClick;
            // 
            // button_AddStaffEmployee
            // 
            button_AddStaffEmployee.Location = new Point(389, 54);
            button_AddStaffEmployee.Name = "button_AddStaffEmployee";
            button_AddStaffEmployee.Size = new Size(75, 23);
            button_AddStaffEmployee.TabIndex = 6;
            button_AddStaffEmployee.Text = "Добавить";
            button_AddStaffEmployee.UseVisualStyleBackColor = true;
            button_AddStaffEmployee.MouseClick += button_AddStaffEmployee_MouseClick;
            // 
            // listBox_Employes
            // 
            listBox_Employes.FormattingEnabled = true;
            listBox_Employes.ItemHeight = 15;
            listBox_Employes.Location = new Point(179, 76);
            listBox_Employes.Name = "listBox_Employes";
            listBox_Employes.SelectionMode = SelectionMode.MultiSimple;
            listBox_Employes.Size = new Size(204, 49);
            listBox_Employes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 76);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Сотрудники";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 42);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 3;
            label2.Text = "Ответственный сотрудник";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_DeleteStaffEmployee);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 235);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Все штабы";
            // 
            // button_DeleteStaffEmployee
            // 
            button_DeleteStaffEmployee.Location = new Point(179, 203);
            button_DeleteStaffEmployee.Name = "button_DeleteStaffEmployee";
            button_DeleteStaffEmployee.Size = new Size(121, 23);
            button_DeleteStaffEmployee.TabIndex = 1;
            button_DeleteStaffEmployee.Text = "Удалить штаб";
            button_DeleteStaffEmployee.UseVisualStyleBackColor = true;
            button_DeleteStaffEmployee.MouseClick += button_DeleteStaffEmployee_MouseClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(473, 175);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button_ToNavigate);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(512, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(762, 427);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Сотрудники";
            // 
            // button_ToNavigate
            // 
            button_ToNavigate.Location = new Point(636, 398);
            button_ToNavigate.Name = "button_ToNavigate";
            button_ToNavigate.Size = new Size(126, 23);
            button_ToNavigate.TabIndex = 2;
            button_ToNavigate.Text = "Вернуться назад";
            button_ToNavigate.UseVisualStyleBackColor = true;
            button_ToNavigate.MouseClick += button_ToNavigate_MouseClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button_ClearEmployee);
            groupBox6.Controls.Add(button_AddEmployee);
            groupBox6.Controls.Add(textBox_SalaryEmployee);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(textBox_EmployeePosition);
            groupBox6.Controls.Add(textBox_NameEmployer);
            groupBox6.Controls.Add(label4);
            groupBox6.Location = new Point(6, 262);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(750, 137);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Добавить сотрудника";
            // 
            // button_ClearEmployee
            // 
            button_ClearEmployee.Location = new Point(567, 80);
            button_ClearEmployee.Name = "button_ClearEmployee";
            button_ClearEmployee.Size = new Size(75, 23);
            button_ClearEmployee.TabIndex = 7;
            button_ClearEmployee.Text = "Отмена";
            button_ClearEmployee.UseVisualStyleBackColor = true;
            button_ClearEmployee.MouseClick += button_ClearEmployee_MouseClick;
            // 
            // button_AddEmployee
            // 
            button_AddEmployee.Location = new Point(567, 34);
            button_AddEmployee.Name = "button_AddEmployee";
            button_AddEmployee.Size = new Size(75, 23);
            button_AddEmployee.TabIndex = 6;
            button_AddEmployee.Text = "Добавить";
            button_AddEmployee.UseVisualStyleBackColor = true;
            button_AddEmployee.MouseClick += button_AddEmployee_MouseClick;
            // 
            // textBox_SalaryEmployee
            // 
            textBox_SalaryEmployee.Location = new Point(113, 85);
            textBox_SalaryEmployee.Name = "textBox_SalaryEmployee";
            textBox_SalaryEmployee.Size = new Size(145, 23);
            textBox_SalaryEmployee.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 88);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 4;
            label6.Text = "Зарплата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 58);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 3;
            label5.Text = "Должность";
            // 
            // textBox_EmployeePosition
            // 
            textBox_EmployeePosition.Location = new Point(114, 55);
            textBox_EmployeePosition.Name = "textBox_EmployeePosition";
            textBox_EmployeePosition.Size = new Size(144, 23);
            textBox_EmployeePosition.TabIndex = 2;
            // 
            // textBox_NameEmployer
            // 
            textBox_NameEmployer.Location = new Point(114, 22);
            textBox_NameEmployer.Name = "textBox_NameEmployer";
            textBox_NameEmployer.Size = new Size(144, 23);
            textBox_NameEmployer.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 0;
            label4.Text = "ФИО Сотрудника";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button_DeleteEmployee);
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(6, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(750, 234);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Все сотрудники";
            // 
            // button_DeleteEmployee
            // 
            button_DeleteEmployee.Location = new Point(318, 202);
            button_DeleteEmployee.Name = "button_DeleteEmployee";
            button_DeleteEmployee.Size = new Size(160, 23);
            button_DeleteEmployee.TabIndex = 2;
            button_DeleteEmployee.Text = "Удалить сотрудника";
            button_DeleteEmployee.UseVisualStyleBackColor = true;
            button_DeleteEmployee.MouseClick += button_DeleteEmployee_MouseClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(738, 174);
            dataGridView2.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "EmployeeForm";
            Text = "Штабы и сотрудники";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button button_CancelStaffEmployee;
        private Button button_AddStaffEmployee;
        private ListBox listBox_Employes;
        private Label label3;
        private Label label2;
        private Button button_DeleteStaffEmployee;
        private GroupBox groupBox4;
        private Button button_ToNavigate;
        private GroupBox groupBox6;
        private Button button_ClearEmployee;
        private Button button_AddEmployee;
        private TextBox textBox_SalaryEmployee;
        private Label label6;
        private Label label5;
        private TextBox textBox_EmployeePosition;
        private TextBox textBox_NameEmployer;
        private Label label4;
        private GroupBox groupBox5;
        private Button button_DeleteEmployee;
        private DataGridView dataGridView2;
        private ComboBox comboBoxManagerEmployeer;
    }
}