namespace ZnosokKurs.Views
{
    partial class AuthForm
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
            textBox_PasswordAuth = new TextBox();
            textBox_LoginAuth = new TextBox();
            panel1 = new Panel();
            button_Exit = new Button();
            button_Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_PasswordAuth
            // 
            textBox_PasswordAuth.Location = new Point(70, 68);
            textBox_PasswordAuth.Name = "textBox_PasswordAuth";
            textBox_PasswordAuth.Size = new Size(203, 23);
            textBox_PasswordAuth.TabIndex = 0;
            textBox_PasswordAuth.UseSystemPasswordChar = true;
            // 
            // textBox_LoginAuth
            // 
            textBox_LoginAuth.Location = new Point(70, 24);
            textBox_LoginAuth.Name = "textBox_LoginAuth";
            textBox_LoginAuth.Size = new Size(203, 23);
            textBox_LoginAuth.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Exit);
            panel1.Controls.Add(button_Enter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_LoginAuth);
            panel1.Controls.Add(textBox_PasswordAuth);
            panel1.Location = new Point(12, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 108);
            panel1.TabIndex = 2;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(291, 68);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(157, 23);
            button_Exit.TabIndex = 5;
            button_Exit.Text = "Выход";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Enter
            // 
            button_Enter.Location = new Point(291, 24);
            button_Enter.Name = "button_Enter";
            button_Enter.Size = new Size(157, 23);
            button_Enter.TabIndex = 4;
            button_Enter.Text = "Войти";
            button_Enter.UseVisualStyleBackColor = true;
            button_Enter.MouseClick += button_Enter_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.busauth;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "AuthForm";
            Text = "Авторизация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_PasswordAuth;
        private TextBox textBox_LoginAuth;
        private Panel panel1;
        private Button button_Exit;
        private Button button_Enter;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}