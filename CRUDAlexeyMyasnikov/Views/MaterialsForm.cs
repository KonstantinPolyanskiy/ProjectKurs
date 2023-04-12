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
    public partial class MaterialsForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_AllMaterials.DataSource = await db.Materials.ToArrayAsync();

                label_CountMaterials.Text = (dataGridView_AllMaterials.DataSource as Material[]).Length.ToString();
            }
        }

        public MaterialsForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private void button_ClearAddMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_HazardIndex.Text = string.Empty;
            textBox_NameMaterials.Text = string.Empty;
            textBox_PriceMaterial.Text = string.Empty;
            textBox_VolumeMaterial.Text = string.Empty;
        }

        private void button_ToNaviagate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void button_AddMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_NameMaterials.Text) ||
                !int.TryParse(textBox_VolumeMaterial.Text, out int volume) ||
                !decimal.TryParse(textBox_PriceMaterial.Text, out decimal price) ||
                !int.TryParse(textBox_HazardIndex.Text, out int index)
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            using (var db = factory.CreateContext())
            {
                var material = new Material()
                {
                    ChemicalHazardIndex = index,
                    Name = textBox_NameMaterials.Text,
                    Price = price,
                    Volume = volume
                };

                await db.Materials.AddAsync(material);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void button_DeleteMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_AllMaterials.SelectedRows.Count < 1) return;

            int index = dataGridView_AllMaterials.SelectedRows[0].Index;

            using (var db = factory.CreateContext())
            {
                db.Materials.Remove
                    ((dataGridView_AllMaterials.DataSource as Material[])[index]);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }
    }
}
