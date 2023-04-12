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
    public partial class EditDoorForm : Form
    {
        private readonly DatabaseFactory factory;
        private int doorId;

        public EditDoorForm(DatabaseFactory factory, int doorId)
        {
            InitializeComponent();
            this.factory = factory;
            this.doorId = doorId;
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

                return (categories, manufacturers, materials);
            }
        }

        private async void AddDoorForm_Load(object sender, EventArgs e)
        {
            var result = await Init();

            CategoriesComboBox.Items.AddRange(result.Item1);
            ManufacturerComboBox.Items.AddRange(result.Item2);
            MaterialsComboBox.Items.AddRange(result.Item3);

            Door door;

            using (var db = factory.CreateContext())
            {
                door = await db.Doors
                    .Include(d => d.Manufacturer)
                    .Include(d => d.Category)
                    .Include(d => d.Material)
                    .SingleAsync(d => d.Id == doorId);
            }

            NameTextBox.Text = door.Name;
            CategoriesComboBox.SelectedIndex = CategoriesComboBox.FindString(door.Category.Name);
            ManufacturerComboBox.SelectedIndex = ManufacturerComboBox.FindString(door.Manufacturer.Name);
            MaterialsComboBox.SelectedIndex = MaterialsComboBox.FindString(door.Material.Name);
            DescriptionTextBox.Text = door.Description ?? string.Empty;
            PriceTextBox.Text = door.Price.ToString();
        }

        private async void ButtonEdit_MouseClick(object sender, MouseEventArgs e)
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
                Door selectedDoor = await db.Doors.SingleAsync(d => d.Id == doorId);

                selectedDoor.Name = NameTextBox.Text;
                selectedDoor.Category = await db.Categories.SingleAsync(c => c.Id == (CategoriesComboBox.SelectedItem as Category).Id);
                selectedDoor.Manufacturer = await db.Manufacturers.SingleAsync(m => m.Id == (ManufacturerComboBox.SelectedItem as Manufacturer).Id);
                selectedDoor.Material = await db.Materials.SingleAsync(m => m.Id == (MaterialsComboBox.SelectedItem as Material).Id);
                selectedDoor.Price = decimal.Parse(PriceTextBox.Text);
                selectedDoor.Description = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text;

                await db.SaveChangesAsync();
            }


            this.Close();
            this.Dispose();
        }
    }
}
