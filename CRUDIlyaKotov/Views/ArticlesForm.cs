using KotovKurs.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotovKurs.Views
{
    public partial class ArticlesForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var c = factory.CreateContext())
            {
                dataGridView_Articles.DataSource = await c.Articles.Include(a => a.Journal).Include(a => a.Author).ToArrayAsync();

                comboBox_EditAuthor.Items.Clear();
                comboBox_EditAuthor.Items.AddRange(await c.Authors.ToArrayAsync());

                comboBox_EditJournalArticle.Items.Clear();
                comboBox_EditJournalArticle.Items.AddRange(await c.Journals.ToArrayAsync());
            }
        }

        public ArticlesForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private void ArticlesForm_Load(object sender, EventArgs e)
        {

        }

        private void button_SaveOrAddArticle_Click(object sender, EventArgs e)
        {
            // сохранить или добавить статью
        }

        private async void button_DeleteArticle_Click(object sender, EventArgs e)
        {
            if (dataGridView_Articles.SelectedRows.Count < 1) return;

            int index = dataGridView_Articles.SelectedRows[0].Index;

            var article = (dataGridView_Articles.DataSource as Article[])[index];

            using (var c = factory.CreateContext())
            {
                c.Articles.Remove(article);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button_ExitEditArticle_Click(object sender, EventArgs e)
        {

        }

        private async void button_SaveOrAddArticle_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_EditArticleTitle.Text) ||
                string.IsNullOrWhiteSpace(textBox_EditDescriptionArticle.Text) ||
                string.IsNullOrWhiteSpace(richTextBox_EditContentArticle.Text) ||
                comboBox_EditAuthor.SelectedItem is not Author ||
                comboBox_EditJournalArticle.SelectedItem is not Journal
            )
            {
                MessageBox.Show("Проверьте корректность введенных данных");
                return;
            }

            using (var c = factory.CreateContext())
            {
                var author = await c.Authors.SingleAsync(a => a.Id == (comboBox_EditAuthor.SelectedItem as Author).Id);
                var journal = await c.Journals.SingleAsync(j => j.Id == (comboBox_EditJournalArticle.SelectedItem as Journal).Id);

                var article = new Article()
                {
                    Author = author,
                    Journal = journal,
                    Text = richTextBox_EditContentArticle.Text,
                    Description = textBox_EditDescriptionArticle.Text,
                    Title = textBox_EditArticleTitle.Text
                };

                await c.Articles.AddAsync(article);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button_ExitEditArticle_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
