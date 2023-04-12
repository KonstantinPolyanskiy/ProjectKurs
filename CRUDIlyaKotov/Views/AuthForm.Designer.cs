namespace KotovKurs.Views
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
            label1 = new Label();
            label2 = new Label();
            textBox_LoginAuth = new TextBox();
            textBox_PasswordAuth = new TextBox();
            button_EnterAuth = new Button();
            button_CancelAuth = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 54);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль:";
            // 
            // textBox_LoginAuth
            // 
            textBox_LoginAuth.Location = new Point(136, 46);
            textBox_LoginAuth.Name = "textBox_LoginAuth";
            textBox_LoginAuth.Size = new Size(147, 23);
            textBox_LoginAuth.TabIndex = 2;
            // 
            // textBox_PasswordAuth
            // 
            textBox_PasswordAuth.Location = new Point(136, 81);
            textBox_PasswordAuth.Name = "textBox_PasswordAuth";
            textBox_PasswordAuth.PasswordChar = '#';
            textBox_PasswordAuth.Size = new Size(147, 23);
            textBox_PasswordAuth.TabIndex = 3;
            // 
            // button_EnterAuth
            // 
            button_EnterAuth.Location = new Point(124, 120);
            button_EnterAuth.Name = "button_EnterAuth";
            button_EnterAuth.Size = new Size(75, 23);
            button_EnterAuth.TabIndex = 4;
            button_EnterAuth.Text = "Войти";
            button_EnterAuth.UseVisualStyleBackColor = true;
            button_EnterAuth.Click += button_EnterAuth_Click;
            button_EnterAuth.MouseClick += button_EnterAuth_MouseClick;
            // 
            // button_CancelAuth
            // 
            button_CancelAuth.Location = new Point(205, 120);
            button_CancelAuth.Name = "button_CancelAuth";
            button_CancelAuth.Size = new Size(75, 23);
            button_CancelAuth.TabIndex = 5;
            button_CancelAuth.Text = "Отмена";
            button_CancelAuth.UseVisualStyleBackColor = true;
            button_CancelAuth.Click += button_CancelAuth_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 166);
            Controls.Add(button_CancelAuth);
            Controls.Add(button_EnterAuth);
            Controls.Add(textBox_PasswordAuth);
            Controls.Add(textBox_LoginAuth);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AuthForm";
            Text = "Добро пожаловать!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_LoginAuth;
        private TextBox textBox_PasswordAuth;
        private Button button_EnterAuth;
        private Button button_CancelAuth;
    }
}