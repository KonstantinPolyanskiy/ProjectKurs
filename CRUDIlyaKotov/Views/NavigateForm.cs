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
    public partial class NavigateForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var c = factory.CreateContext())
            {
                dataGridView_Users.DataSource = await c.Users.ToArrayAsync();
            }
        }

        public NavigateForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private void button_SaveOrAddUser_Click(object sender, EventArgs e)
        {
            // сохранение или добавление, ну сам знаешь эту тему
        }

        private void button_ToArticles_Click(object sender, EventArgs e)
        {

        }

        private void button_ToAuthors_Click(object sender, EventArgs e)
        {

        }

        private void button_ToJournal_Click(object sender, EventArgs e)
        {
            // переход к журналам
        }

        private void button_ToReviews_Click(object sender, EventArgs e)
        {

        }

        private async void button_SaveOrAddUser_MouseClick(object sender, MouseEventArgs e)
        {
            string[] fullName = textBox_FioUser.Text.Split(' ');

            if
            (
                string.IsNullOrWhiteSpace(textBox_FioUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_EmailUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_CountryUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_LoginUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_PasswordUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_PhoneUser.Text) ||
                fullName.Length != 3
            )
            {
                MessageBox.Show("Проверьте корректность введенных данных");
                return;
            }

            using (var c = factory.CreateContext())
            {
                var user = new User()
                {
                    Country = textBox_CountryUser.Text,
                    Surname = fullName[0],
                    Email = textBox_EmailUser.Text,
                    LastName = fullName[2],
                    Login = textBox_LoginUser.Text,
                    Name = fullName[1],
                    Password = textBox_PasswordUser.Text,
                    Phone = textBox_PhoneUser.Text
                };

                await c.Users.AddAsync(user);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void button_DeleteUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_Users.SelectedRows.Count < 1) return;

            int index = dataGridView_Users.SelectedRows[0].Index;

            var user = (dataGridView_Users.DataSource as User[])[index];

            using (var c = factory.CreateContext())
            {
                c.Users.Remove(user);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button_ToAuthors_MouseClick(object sender, MouseEventArgs e)
        {
            new AuthorsForm(factory).ShowDialog();
        }

        private void button_ToJournal_MouseClick(object sender, MouseEventArgs e)
        {
            new JournalsForm(factory).ShowDialog();
        }

        private void button_ToReviews_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            new ReviewsForm(factory).ShowDialog();
            Visible = true;
        }

        private void button_ToArticles_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            new ArticlesForm(factory).ShowDialog();
            Visible = true;
        }
    }
}
