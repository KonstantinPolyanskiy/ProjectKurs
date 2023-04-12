namespace DanilSalikov.Views
{
    partial class AddCategory
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
            button2 = new Button();
            ButtonAdd = new Button();
            label7 = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            label6 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(171, 180);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 36;
            button2.Text = "Закрыть";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button2_MouseClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(90, 180);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 35;
            ButtonAdd.Text = "Добавить";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.MouseClick += ButtonAdd_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(90, 27);
            label7.Name = "label7";
            label7.Size = new Size(144, 23);
            label7.TabIndex = 34;
            label7.Text = "Создать запись";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(171, 117);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(138, 23);
            DescriptionTextBox.TabIndex = 33;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(171, 72);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(138, 23);
            NameTextBox.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 120);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 31;
            label6.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 69);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 30;
            label1.Text = "Название";
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 226);
            Controls.Add(button2);
            Controls.Add(ButtonAdd);
            Controls.Add(label7);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "AddCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить категорию";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button ButtonAdd;
        private Label label7;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Label label6;
        private Label label1;
    }
}