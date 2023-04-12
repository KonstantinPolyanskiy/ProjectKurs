using DanilSalikov.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanilSalikov.Views
{
    public partial class AddCategory : Form
    {
        private readonly DatabaseFactory _factory;

        public AddCategory(DatabaseFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private async void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Вы не ввели название");
                return;
            }

            using (var context = _factory.CreateContext())
            {
                await context.Categories.AddAsync
                    (
                        new Category() { Name = NameTextBox.Text, Description = DescriptionTextBox.Text }
                    );

                await context.SaveChangesAsync();
            }

            this.Close();
            this.Dispose();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
