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
    public partial class ReviewsForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var c = factory.CreateContext())
            {
                dataGridView1.DataSource = await c.Reviews.ToArrayAsync();

                comboBox_EditArticleReview.Items.Clear();
                comboBox_EditArticleReview.Items.AddRange(await c.Articles.ToArrayAsync());

                comboBox_EditAuthorReview.Items.Clear();
                comboBox_EditAuthorReview.Items.AddRange(await c.Authors.ToArrayAsync());
            }
        }

        public ReviewsForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private void button_ExitReviewsEdit_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            Dispose();
        }

        private async void button_DeleteReview_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            int index = dataGridView1.SelectedRows[0].Index;

            var review = (dataGridView1.DataSource as Review[])[index];

            using (var c = factory.CreateContext())
            {
                c.Reviews.Remove(review);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void button_AddOrSaveReview_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_EditNameReview.Text) ||
                comboBox_EditArticleReview.SelectedItem is not Article ||
                comboBox_EditAuthorReview.SelectedItem is not Author ||
                string.IsNullOrWhiteSpace(richTextBox_EditTextReview.Text)
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            using (var c = factory.CreateContext())
            {
                var article = await c.Articles.SingleAsync(a => a.Id == (comboBox_EditArticleReview.SelectedItem as Article).Id);
                var author = await c.Authors.SingleAsync(a => a.Id == (comboBox_EditAuthorReview.SelectedItem as Author).Id);

                var review = new Review()
                {
                    Article = article,
                    Author = author,
                    Text = textBox_EditNameReview.Text,
                    Title = richTextBox_EditTextReview.Text
                };

                await c.Reviews.AddAsync(review);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }
    }
}
