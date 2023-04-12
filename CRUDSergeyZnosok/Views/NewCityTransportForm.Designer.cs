namespace ZnosokKurs.Views
{
    partial class NewCityTransportForm
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
            button_CancelCityTransport = new Button();
            button_AddCityTransport = new Button();
            comboBox_UsedRoute = new ComboBox();
            label3 = new Label();
            comboBox_TypeTransport = new ComboBox();
            textBox_NumberCityTransport = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_CancelCityTransport);
            groupBox1.Controls.Add(button_AddCityTransport);
            groupBox1.Controls.Add(comboBox_UsedRoute);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox_TypeTransport);
            groupBox1.Controls.Add(textBox_NumberCityTransport);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новый городской транспорт";
            // 
            // button_CancelCityTransport
            // 
            button_CancelCityTransport.Location = new Point(190, 177);
            button_CancelCityTransport.Name = "button_CancelCityTransport";
            button_CancelCityTransport.Size = new Size(75, 23);
            button_CancelCityTransport.TabIndex = 8;
            button_CancelCityTransport.Text = "Отмена";
            button_CancelCityTransport.UseVisualStyleBackColor = true;
            // 
            // button_AddCityTransport
            // 
            button_AddCityTransport.Location = new Point(82, 177);
            button_AddCityTransport.Name = "button_AddCityTransport";
            button_AddCityTransport.Size = new Size(75, 23);
            button_AddCityTransport.TabIndex = 7;
            button_AddCityTransport.Text = "Добавить ";
            button_AddCityTransport.UseVisualStyleBackColor = true;
            button_AddCityTransport.MouseClick += button_AddCityTransport_MouseClick;
            // 
            // comboBox_UsedRoute
            // 
            comboBox_UsedRoute.FormattingEnabled = true;
            comboBox_UsedRoute.Location = new Point(163, 122);
            comboBox_UsedRoute.Name = "comboBox_UsedRoute";
            comboBox_UsedRoute.Size = new Size(180, 23);
            comboBox_UsedRoute.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 125);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 5;
            label3.Text = "Используемый маршрут:";
            // 
            // comboBox_TypeTransport
            // 
            comboBox_TypeTransport.FormattingEnabled = true;
            comboBox_TypeTransport.Location = new Point(163, 90);
            comboBox_TypeTransport.Name = "comboBox_TypeTransport";
            comboBox_TypeTransport.Size = new Size(180, 23);
            comboBox_TypeTransport.TabIndex = 4;
            // 
            // textBox_NumberCityTransport
            // 
            textBox_NumberCityTransport.Location = new Point(163, 51);
            textBox_NumberCityTransport.Name = "textBox_NumberCityTransport";
            textBox_NumberCityTransport.Size = new Size(180, 23);
            textBox_NumberCityTransport.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 90);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Тип транспорта:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 54);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер гор. транспорта:";
            // 
            // NewCityTransportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 230);
            Controls.Add(groupBox1);
            Name = "NewCityTransportForm";
            Text = "Добавление городского транспорта";
            Load += NewCityTransportForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox_NumberCityTransport;
        private ComboBox comboBox_UsedRoute;
        private Label label3;
        private ComboBox comboBox_TypeTransport;
        private Button button_CancelCityTransport;
        private Button button_AddCityTransport;
    }
}