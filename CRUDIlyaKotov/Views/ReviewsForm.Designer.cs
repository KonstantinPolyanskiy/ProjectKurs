namespace KotovKurs.Views
{
    partial class ReviewsForm
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            richTextBox_EditTextReview = new RichTextBox();
            label4 = new Label();
            button_DeleteReview = new Button();
            button_AddOrSaveReview = new Button();
            comboBox_EditArticleReview = new ComboBox();
            label3 = new Label();
            comboBox_EditAuthorReview = new ComboBox();
            label2 = new Label();
            textBox_EditNameReview = new TextBox();
            label1 = new Label();
            button_ExitReviewsEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(560, 311);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox_EditTextReview);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button_DeleteReview);
            groupBox1.Controls.Add(button_AddOrSaveReview);
            groupBox1.Controls.Add(comboBox_EditArticleReview);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox_EditAuthorReview);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_EditNameReview);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Рецензия";
            // 
            // richTextBox_EditTextReview
            // 
            richTextBox_EditTextReview.Location = new Point(244, 40);
            richTextBox_EditTextReview.Name = "richTextBox_EditTextReview";
            richTextBox_EditTextReview.Size = new Size(229, 107);
            richTextBox_EditTextReview.TabIndex = 9;
            richTextBox_EditTextReview.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 19);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Текст:";
            // 
            // button_DeleteReview
            // 
            button_DeleteReview.Location = new Point(163, 141);
            button_DeleteReview.Name = "button_DeleteReview";
            button_DeleteReview.Size = new Size(75, 23);
            button_DeleteReview.TabIndex = 7;
            button_DeleteReview.Text = "Удалить";
            button_DeleteReview.UseVisualStyleBackColor = true;
            button_DeleteReview.MouseClick += button_DeleteReview_MouseClick;
            // 
            // button_AddOrSaveReview
            // 
            button_AddOrSaveReview.Location = new Point(74, 141);
            button_AddOrSaveReview.Name = "button_AddOrSaveReview";
            button_AddOrSaveReview.Size = new Size(75, 23);
            button_AddOrSaveReview.TabIndex = 6;
            button_AddOrSaveReview.Text = "Сохранить";
            button_AddOrSaveReview.UseVisualStyleBackColor = true;
            button_AddOrSaveReview.MouseClick += button_AddOrSaveReview_MouseClick;
            // 
            // comboBox_EditArticleReview
            // 
            comboBox_EditArticleReview.FormattingEnabled = true;
            comboBox_EditArticleReview.Location = new Point(74, 98);
            comboBox_EditArticleReview.Name = "comboBox_EditArticleReview";
            comboBox_EditArticleReview.Size = new Size(164, 23);
            comboBox_EditArticleReview.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Статья:";
            // 
            // comboBox_EditAuthorReview
            // 
            comboBox_EditAuthorReview.FormattingEnabled = true;
            comboBox_EditAuthorReview.Location = new Point(74, 69);
            comboBox_EditAuthorReview.Name = "comboBox_EditAuthorReview";
            comboBox_EditAuthorReview.Size = new Size(164, 23);
            comboBox_EditAuthorReview.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Автор:";
            // 
            // textBox_EditNameReview
            // 
            textBox_EditNameReview.Location = new Point(74, 40);
            textBox_EditNameReview.Name = "textBox_EditNameReview";
            textBox_EditNameReview.Size = new Size(164, 23);
            textBox_EditNameReview.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // button_ExitReviewsEdit
            // 
            button_ExitReviewsEdit.Location = new Point(497, 476);
            button_ExitReviewsEdit.Name = "button_ExitReviewsEdit";
            button_ExitReviewsEdit.Size = new Size(75, 23);
            button_ExitReviewsEdit.TabIndex = 2;
            button_ExitReviewsEdit.Text = "Назад";
            button_ExitReviewsEdit.UseVisualStyleBackColor = true;
            button_ExitReviewsEdit.MouseClick += button_ExitReviewsEdit_MouseClick;
            // 
            // ReviewsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 511);
            Controls.Add(button_ExitReviewsEdit);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "ReviewsForm";
            Text = "Рецензии";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox_EditTextReview;
        private Label label4;
        private Button button_DeleteReview;
        private Button button_AddOrSaveReview;
        private ComboBox comboBox_EditArticleReview;
        private Label label3;
        private ComboBox comboBox_EditAuthorReview;
        private Label label2;
        private TextBox textBox_EditNameReview;
        private Label label1;
        private Button button_ExitReviewsEdit;
    }
}