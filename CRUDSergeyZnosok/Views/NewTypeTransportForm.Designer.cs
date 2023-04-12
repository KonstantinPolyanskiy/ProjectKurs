namespace ZnosokKurs.Views
{
    partial class NewTypeTransportForm
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
            button_CancelTypeTransport = new Button();
            button_AddTypeTransport = new Button();
            richTextBox_TransportCharacteristic = new RichTextBox();
            label2 = new Label();
            textBox_TransportName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_CancelTypeTransport);
            groupBox1.Controls.Add(button_AddTypeTransport);
            groupBox1.Controls.Add(richTextBox_TransportCharacteristic);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_TransportName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новый тип транспорта";
            // 
            // button_CancelTypeTransport
            // 
            button_CancelTypeTransport.Location = new Point(6, 192);
            button_CancelTypeTransport.Name = "button_CancelTypeTransport";
            button_CancelTypeTransport.Size = new Size(159, 23);
            button_CancelTypeTransport.TabIndex = 5;
            button_CancelTypeTransport.Text = "Отмена";
            button_CancelTypeTransport.UseVisualStyleBackColor = true;
            button_CancelTypeTransport.MouseClick += button_CancelTypeTransport_MouseClick;
            // 
            // button_AddTypeTransport
            // 
            button_AddTypeTransport.Location = new Point(6, 136);
            button_AddTypeTransport.Name = "button_AddTypeTransport";
            button_AddTypeTransport.Size = new Size(160, 25);
            button_AddTypeTransport.TabIndex = 4;
            button_AddTypeTransport.Text = "Добавить";
            button_AddTypeTransport.UseVisualStyleBackColor = true;
            button_AddTypeTransport.MouseClick += button_AddTypeTransport_MouseClick;
            // 
            // richTextBox_TransportCharacteristic
            // 
            richTextBox_TransportCharacteristic.Location = new Point(171, 75);
            richTextBox_TransportCharacteristic.Name = "richTextBox_TransportCharacteristic";
            richTextBox_TransportCharacteristic.Size = new Size(183, 140);
            richTextBox_TransportCharacteristic.TabIndex = 3;
            richTextBox_TransportCharacteristic.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 2;
            label2.Text = "Характеристика транспорта:";
            // 
            // textBox_TransportName
            // 
            textBox_TransportName.Location = new Point(171, 39);
            textBox_TransportName.Name = "textBox_TransportName";
            textBox_TransportName.Size = new Size(183, 23);
            textBox_TransportName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Название транспорта:";
            // 
            // NewTypeTransportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 246);
            Controls.Add(groupBox1);
            Name = "NewTypeTransportForm";
            Text = "Добавление нового типа транспорта";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_CancelTypeTransport;
        private Button button_AddTypeTransport;
        private RichTextBox richTextBox_TransportCharacteristic;
        private Label label2;
        private TextBox textBox_TransportName;
        private Label label1;
    }
}