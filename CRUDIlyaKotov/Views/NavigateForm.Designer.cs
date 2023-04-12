namespace KotovKurs.Views
{
    partial class NavigateForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            button_ToReviews = new Button();
            button_ToJournal = new Button();
            button_ToAuthors = new Button();
            button_ToArticles = new Button();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            button_DeleteUser = new Button();
            button_SaveOrAddUser = new Button();
            groupBox1 = new GroupBox();
            textBox_PasswordUser = new TextBox();
            label6 = new Label();
            textBox_LoginUser = new TextBox();
            label5 = new Label();
            textBox_CountryUser = new TextBox();
            label4 = new Label();
            textBox_EmailUser = new TextBox();
            label3 = new Label();
            textBox_PhoneUser = new TextBox();
            textBox_FioUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView_Users = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Users).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 467);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 439);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Навигация";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_ToReviews);
            groupBox2.Controls.Add(button_ToJournal);
            groupBox2.Controls.Add(button_ToAuthors);
            groupBox2.Controls.Add(button_ToArticles);
            groupBox2.Location = new Point(6, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 68);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // button_ToReviews
            // 
            button_ToReviews.Location = new Point(357, 22);
            button_ToReviews.Name = "button_ToReviews";
            button_ToReviews.Size = new Size(75, 23);
            button_ToReviews.TabIndex = 3;
            button_ToReviews.Text = "Рецензии";
            button_ToReviews.UseVisualStyleBackColor = true;
            button_ToReviews.Click += button_ToReviews_Click;
            button_ToReviews.MouseClick += button_ToReviews_MouseClick;
            // 
            // button_ToJournal
            // 
            button_ToJournal.Location = new Point(276, 22);
            button_ToJournal.Name = "button_ToJournal";
            button_ToJournal.Size = new Size(75, 23);
            button_ToJournal.TabIndex = 2;
            button_ToJournal.Text = "Журналы";
            button_ToJournal.UseVisualStyleBackColor = true;
            button_ToJournal.Click += button_ToJournal_Click;
            button_ToJournal.MouseClick += button_ToJournal_MouseClick;
            // 
            // button_ToAuthors
            // 
            button_ToAuthors.Location = new Point(195, 22);
            button_ToAuthors.Name = "button_ToAuthors";
            button_ToAuthors.Size = new Size(75, 23);
            button_ToAuthors.TabIndex = 1;
            button_ToAuthors.Text = "Авторы";
            button_ToAuthors.UseVisualStyleBackColor = true;
            button_ToAuthors.Click += button_ToAuthors_Click;
            button_ToAuthors.MouseClick += button_ToAuthors_MouseClick;
            // 
            // button_ToArticles
            // 
            button_ToArticles.Location = new Point(114, 22);
            button_ToArticles.Name = "button_ToArticles";
            button_ToArticles.Size = new Size(75, 23);
            button_ToArticles.TabIndex = 0;
            button_ToArticles.Text = "Статьи";
            button_ToArticles.UseVisualStyleBackColor = true;
            button_ToArticles.Click += button_ToArticles_Click;
            button_ToArticles.MouseClick += button_ToArticles_MouseClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.journal__1_;
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 353);
            panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button_DeleteUser);
            tabPage2.Controls.Add(button_SaveOrAddUser);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dataGridView_Users);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 439);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пользователи";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_DeleteUser
            // 
            button_DeleteUser.Location = new Point(369, 341);
            button_DeleteUser.Name = "button_DeleteUser";
            button_DeleteUser.Size = new Size(135, 30);
            button_DeleteUser.TabIndex = 3;
            button_DeleteUser.Text = "Удалить";
            button_DeleteUser.UseVisualStyleBackColor = true;
            button_DeleteUser.MouseClick += button_DeleteUser_MouseClick;
            // 
            // button_SaveOrAddUser
            // 
            button_SaveOrAddUser.Location = new Point(369, 297);
            button_SaveOrAddUser.Name = "button_SaveOrAddUser";
            button_SaveOrAddUser.Size = new Size(135, 30);
            button_SaveOrAddUser.TabIndex = 2;
            button_SaveOrAddUser.Text = "Добавить";
            button_SaveOrAddUser.UseVisualStyleBackColor = true;
            button_SaveOrAddUser.Click += button_SaveOrAddUser_Click;
            button_SaveOrAddUser.MouseClick += button_SaveOrAddUser_MouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_PasswordUser);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_LoginUser);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_CountryUser);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_EmailUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_PhoneUser);
            groupBox1.Controls.Add(textBox_FioUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // textBox_PasswordUser
            // 
            textBox_PasswordUser.Location = new Point(125, 159);
            textBox_PasswordUser.Name = "textBox_PasswordUser";
            textBox_PasswordUser.Size = new Size(165, 23);
            textBox_PasswordUser.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 162);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Пароль:";
            // 
            // textBox_LoginUser
            // 
            textBox_LoginUser.Location = new Point(125, 128);
            textBox_LoginUser.Name = "textBox_LoginUser";
            textBox_LoginUser.Size = new Size(165, 23);
            textBox_LoginUser.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 131);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Логин:";
            // 
            // textBox_CountryUser
            // 
            textBox_CountryUser.Location = new Point(125, 99);
            textBox_CountryUser.Name = "textBox_CountryUser";
            textBox_CountryUser.Size = new Size(165, 23);
            textBox_CountryUser.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 103);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Страна:";
            // 
            // textBox_EmailUser
            // 
            textBox_EmailUser.Location = new Point(125, 70);
            textBox_EmailUser.Name = "textBox_EmailUser";
            textBox_EmailUser.Size = new Size(165, 23);
            textBox_EmailUser.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Почта:";
            // 
            // textBox_PhoneUser
            // 
            textBox_PhoneUser.Location = new Point(125, 41);
            textBox_PhoneUser.Name = "textBox_PhoneUser";
            textBox_PhoneUser.Size = new Size(165, 23);
            textBox_PhoneUser.TabIndex = 3;
            // 
            // textBox_FioUser
            // 
            textBox_FioUser.Location = new Point(125, 13);
            textBox_FioUser.Name = "textBox_FioUser";
            textBox_FioUser.Size = new Size(165, 23);
            textBox_FioUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 45);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Телефон:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 16);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО пользователя:";
            // 
            // dataGridView_Users
            // 
            dataGridView_Users.AllowUserToAddRows = false;
            dataGridView_Users.AllowUserToDeleteRows = false;
            dataGridView_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Users.Location = new Point(6, 3);
            dataGridView_Users.MultiSelect = false;
            dataGridView_Users.Name = "dataGridView_Users";
            dataGridView_Users.ReadOnly = true;
            dataGridView_Users.RowTemplate.Height = 25;
            dataGridView_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Users.Size = new Size(540, 230);
            dataGridView_Users.TabIndex = 0;
            // 
            // NavigateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(584, 491);
            Controls.Add(tabControl1);
            Name = "NavigateForm";
            Text = "Главная";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_DeleteUser;
        private Button button_SaveOrAddUser;
        private GroupBox groupBox1;
        private TextBox textBox_PasswordUser;
        private Label label6;
        private TextBox textBox_LoginUser;
        private Label label5;
        private TextBox textBox_CountryUser;
        private Label label4;
        private TextBox textBox_EmailUser;
        private Label label3;
        private TextBox textBox_PhoneUser;
        private TextBox textBox_FioUser;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView_Users;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button button_ToReviews;
        private Button button_ToJournal;
        private Button button_ToAuthors;
        private Button button_ToArticles;
    }
}