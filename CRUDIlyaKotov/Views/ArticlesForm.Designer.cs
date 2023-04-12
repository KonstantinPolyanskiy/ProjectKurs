namespace KotovKurs.Views
{
    partial class ArticlesForm
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
            dataGridView_Articles = new DataGridView();
            groupBox1 = new GroupBox();
            button_DeleteArticle = new Button();
            button_SaveOrAddArticle = new Button();
            richTextBox_EditContentArticle = new RichTextBox();
            label5 = new Label();
            comboBox_EditJournalArticle = new ComboBox();
            label4 = new Label();
            textBox_EditDescriptionArticle = new TextBox();
            label3 = new Label();
            comboBox_EditAuthor = new ComboBox();
            label2 = new Label();
            textBox_EditArticleTitle = new TextBox();
            label1 = new Label();
            button_ExitEditArticle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Articles).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Articles
            // 
            dataGridView_Articles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Articles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView_Articles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Articles.Location = new Point(12, 12);
            dataGridView_Articles.MultiSelect = false;
            dataGridView_Articles.Name = "dataGridView_Articles";
            dataGridView_Articles.RowTemplate.Height = 25;
            dataGridView_Articles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Articles.Size = new Size(776, 205);
            dataGridView_Articles.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_DeleteArticle);
            groupBox1.Controls.Add(button_SaveOrAddArticle);
            groupBox1.Controls.Add(richTextBox_EditContentArticle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox_EditJournalArticle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_EditDescriptionArticle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox_EditAuthor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_EditArticleTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 223);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 215);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Статья";
            // 
            // button_DeleteArticle
            // 
            button_DeleteArticle.Location = new Point(213, 165);
            button_DeleteArticle.Name = "button_DeleteArticle";
            button_DeleteArticle.Size = new Size(75, 23);
            button_DeleteArticle.TabIndex = 11;
            button_DeleteArticle.Text = "Удалить";
            button_DeleteArticle.UseVisualStyleBackColor = true;
            button_DeleteArticle.Click += button_DeleteArticle_Click;
            // 
            // button_SaveOrAddArticle
            // 
            button_SaveOrAddArticle.Location = new Point(101, 165);
            button_SaveOrAddArticle.Name = "button_SaveOrAddArticle";
            button_SaveOrAddArticle.Size = new Size(75, 23);
            button_SaveOrAddArticle.TabIndex = 10;
            button_SaveOrAddArticle.Text = "Сохранить";
            button_SaveOrAddArticle.UseVisualStyleBackColor = true;
            button_SaveOrAddArticle.Click += button_SaveOrAddArticle_Click;
            button_SaveOrAddArticle.MouseClick += button_SaveOrAddArticle_MouseClick;
            // 
            // richTextBox_EditContentArticle
            // 
            richTextBox_EditContentArticle.Location = new Point(403, 36);
            richTextBox_EditContentArticle.Name = "richTextBox_EditContentArticle";
            richTextBox_EditContentArticle.Size = new Size(274, 161);
            richTextBox_EditContentArticle.TabIndex = 9;
            richTextBox_EditContentArticle.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 18);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Содержание:";
            // 
            // comboBox_EditJournalArticle
            // 
            comboBox_EditJournalArticle.FormattingEnabled = true;
            comboBox_EditJournalArticle.Location = new Point(191, 118);
            comboBox_EditJournalArticle.Name = "comboBox_EditJournalArticle";
            comboBox_EditJournalArticle.Size = new Size(193, 23);
            comboBox_EditJournalArticle.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 121);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Журнал:";
            // 
            // textBox_EditDescriptionArticle
            // 
            textBox_EditDescriptionArticle.Location = new Point(191, 90);
            textBox_EditDescriptionArticle.Name = "textBox_EditDescriptionArticle";
            textBox_EditDescriptionArticle.Size = new Size(193, 23);
            textBox_EditDescriptionArticle.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 93);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Краткое описание:";
            // 
            // comboBox_EditAuthor
            // 
            comboBox_EditAuthor.FormattingEnabled = true;
            comboBox_EditAuthor.Location = new Point(191, 63);
            comboBox_EditAuthor.Name = "comboBox_EditAuthor";
            comboBox_EditAuthor.Size = new Size(193, 23);
            comboBox_EditAuthor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 66);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Автор:";
            // 
            // textBox_EditArticleTitle
            // 
            textBox_EditArticleTitle.Location = new Point(191, 36);
            textBox_EditArticleTitle.Name = "textBox_EditArticleTitle";
            textBox_EditArticleTitle.Size = new Size(193, 23);
            textBox_EditArticleTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Заголовок статьи:";
            // 
            // button_ExitEditArticle
            // 
            button_ExitEditArticle.Location = new Point(713, 415);
            button_ExitEditArticle.Name = "button_ExitEditArticle";
            button_ExitEditArticle.Size = new Size(75, 23);
            button_ExitEditArticle.TabIndex = 2;
            button_ExitEditArticle.Text = "Назад";
            button_ExitEditArticle.UseVisualStyleBackColor = true;
            button_ExitEditArticle.Click += button_ExitEditArticle_Click;
            button_ExitEditArticle.MouseClick += button_ExitEditArticle_MouseClick;
            // 
            // ArticlesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(button_ExitEditArticle);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView_Articles);
            Name = "ArticlesForm";
            Text = "Статьи";
            Load += ArticlesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Articles).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Articles;
        private GroupBox groupBox1;
        private ComboBox comboBox_EditAuthor;
        private Label label2;
        private TextBox textBox_EditArticleTitle;
        private Label label1;
        private RichTextBox richTextBox_EditContentArticle;
        private Label label5;
        private ComboBox comboBox_EditJournalArticle;
        private Label label4;
        private TextBox textBox_EditDescriptionArticle;
        private Label label3;
        private Button button_DeleteArticle;
        private Button button_SaveOrAddArticle;
        private Button button_ExitEditArticle;
    }
}