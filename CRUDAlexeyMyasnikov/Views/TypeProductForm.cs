using FarmKurs.Database;
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

namespace FarmKurs.Views
{
    public partial class TypeProductForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_TypeProduct.DataSource = await db.TypesProduct.ToArrayAsync();
            }
        }

        public TypeProductForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_ClearTypeProduct_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox_DescriptionTypeProduct.Text = string.Empty;
            textBox_NameTypeProduct.Text = string.Empty;
        }

        private async void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_TypeProduct.SelectedRows.Count < 1) return;

            int index = dataGridView_TypeProduct.SelectedRows[0].Index;

            using (var db = factory.CreateContext())
            {
                db.TypesProduct.Remove((dataGridView_TypeProduct.DataSource as TypeProduct[])[index]);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void button_AddTypeProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_NameTypeProduct.Text) ||
                string.IsNullOrWhiteSpace(richTextBox_DescriptionTypeProduct.Text)
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            var type = new TypeProduct()
            {
                Name = textBox_NameTypeProduct.Text,
                Description = richTextBox_DescriptionTypeProduct.Text
            };

            using (var db = factory.CreateContext())
            {
                await db.TypesProduct.AddAsync(type);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }
    }
}
