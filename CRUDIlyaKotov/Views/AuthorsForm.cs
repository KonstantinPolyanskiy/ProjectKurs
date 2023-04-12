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
    public partial class AuthorsForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var c = factory.CreateContext())
            {
                dataGridView1.DataSource = await c.Authors.ToArrayAsync();
            }
        }

        public AuthorsForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private async void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text)
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            var author = new Author()
            {
                Phone = textBox1.Text,
                Email = textBox2.Text,
                Organization = textBox3.Text,
                Country = textBox4.Text,
                Surname = textBox5.Text,
                Name = textBox6.Text,
                LastName = textBox7.Text
            };

            using (var c = factory.CreateContext())
            {
                await c.Authors.AddAsync(author);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }
    }
}
