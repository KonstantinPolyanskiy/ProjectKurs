using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DanilSalikov.Database;
using Microsoft.EntityFrameworkCore;

namespace DanilSalikov.Views
{
    public partial class AddDoorForm : Form
    {
        private readonly DatabaseFactory factory;

        public AddDoorForm(DatabaseFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
        }

        private async Task<(Category[], Manufacturer[], Material[])> Init()
        {
            Category[] categories;
            Manufacturer[] manufacturers;
            Material[] materials;

            using (var db = factory.CreateContext())
            {
                categories = await db.Categories.ToArrayAsync();
                manufacturers = await db.Manufacturers.ToArrayAsync();
                materials = await db.Materials.ToArrayAsync();
            }

            return (categories, manufacturers, materials);
        }

        private async void AddDoorForm_Load(object sender, EventArgs e)
        {
            var result = await Init();

            CategoriesComboBox.Items.AddRange(result.Item1);
            ManufacturerComboBox.Items.AddRange(result.Item2);
            MaterialsComboBox.Items.AddRange(result.Item3);
        }

        private async void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Введите название");
                return;
            }

            if (CategoriesComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите категорию");
                return;
            }

            if (ManufacturerComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите производителя");
                return;
            }

            if (MaterialsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите материал");
                return;
            }

            if (string.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                MessageBox.Show("Введите цену");
                return;
            }

            using (var db = factory.CreateContext())
            {
                await db.Doors.AddAsync
                (
                    new Door()
                    {
                        Name = NameTextBox.Text,
                        Category = await db.Categories.SingleAsync(c => c.Id == (CategoriesComboBox.SelectedItem as Category).Id),
                        Manufacturer = await db.Manufacturers.SingleAsync(m => m.Id == (ManufacturerComboBox.SelectedItem as Manufacturer).Id),
                        Material = await db.Materials.SingleAsync(m => m.Id == (MaterialsComboBox.SelectedItem as Material).Id),
                        Price = decimal.Parse(PriceTextBox.Text),
                        Description = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text
                    }
                );

                await db.SaveChangesAsync();
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
