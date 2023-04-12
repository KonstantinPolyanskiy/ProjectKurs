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
    public partial class ProductsForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var db = factory.CreateContext())
            {
                var arr = await db.Products.Include(p => p.FromLaboratory).Include(p => p.Type).ToArrayAsync();

                dataGridView_AddProducts.DataSource = arr;
                label_CountAllProducts.Text = arr.Length.ToString();

                comboBoxLaboratories.Items.Clear();
                comboBoxLaboratories.Items.AddRange(await db.Laboratories.ToArrayAsync());

                comboBox_TypeProduct.Items.Clear();
                comboBox_TypeProduct.Items.AddRange(await db.TypesProduct.ToArrayAsync());
            }
        }

        public ProductsForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private void button_ToNavigate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_ClearProduct_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_CountProduct.Text = string.Empty;
            textBox_PriceProduct.Text = string.Empty;
            comboBox_TypeProduct.SelectedIndex = -1;
            textBox_NameProduct.Text = string.Empty;
            comboBoxLaboratories.SelectedIndex = -1;
        }

        private async void button_DeleteProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_AddProducts.SelectedRows.Count < 1) return;

            int index = dataGridView_AddProducts.SelectedRows[0].Index;

            using (var db = factory.CreateContext())
            {
                db.Products.Remove((dataGridView_AddProducts.DataSource as Product[])[index]);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void button_AddProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                !int.TryParse(textBox_CountProduct.Text, out int count) ||
                !decimal.TryParse(textBox_PriceProduct.Text, out decimal price) ||
                string.IsNullOrWhiteSpace(textBox_NameProduct.Text) ||
                comboBoxLaboratories.SelectedItem is not Laboratory ||
                comboBox_TypeProduct.SelectedItem is not TypeProduct
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            using (var db = factory.CreateContext())
            {
                var product = new Product()
                {
                    Count = count,
                    Price = price,
                    FromLaboratory = await db.Laboratories.SingleAsync(l => l.Id == (comboBoxLaboratories.SelectedItem as Laboratory).Id),
                    Type = await db.TypesProduct.SingleAsync(t => t.Id == (comboBox_TypeProduct.SelectedItem as TypeProduct).Id),
                    Name = textBox_NameProduct.Text
                };

                await db.Products.AddAsync(product);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_AddProducts.DataSource = await db.Products
                    .Include(p => p.FromLaboratory)
                    .Include(p => p.Type)
                    .Where
                    (
                        p =>
                            p.Id.ToString().Contains(textBoxSearch.Text) ||
                            p.FromLaboratory.Id.ToString().Contains(textBoxSearch.Text) ||
                            p.Name.Contains(textBoxSearch.Text) ||
                            p.Count.ToString().Contains(textBoxSearch.Text) ||
                            p.Price.ToString().Contains(textBoxSearch.Text) ||
                            p.Type.Name.Contains(textBoxSearch.Text)
                    )
                    .ToArrayAsync();
            }
        }

        private void button_ResetSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }
    }
}
