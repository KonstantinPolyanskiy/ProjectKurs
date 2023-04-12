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
    public partial class LaboratoryForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_AllLab.DataSource = await db.Laboratories.Include(l => l.UseMaterial).Include(l => l.StaffHeadQuaters).ToArrayAsync();

                comboBox_EmployeeStaff.Items.Clear();
                comboBox_EmployeeStaff.Items.AddRange(await db.StaffHeadQuaters.ToArrayAsync());

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(await db.Materials.ToArrayAsync());
            }
        }

        public LaboratoryForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }

        private async void LaboratoryForm_Load(object sender, EventArgs e)
        {
            await UpdateDataGridView();
        }

        private async void button_DeleteLab_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_AllLab.SelectedRows.Count < 1) return;

            int index = dataGridView_AllLab.SelectedRows[0].Index;

            using (var db = factory.CreateContext())
            {
                db.Laboratories.Remove((dataGridView_AllLab.DataSource as Laboratory[])[index]);
                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button_ClearLab_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_EmployeeStaff.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBox1.Text = string.Empty;
        }

        private async void button_AddLab_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                !int.TryParse(textBox1.Text, out int perfomance) ||
                comboBox1.SelectedItem is not Material ||
                comboBox_EmployeeStaff.SelectedItem is not StaffHeadQuaters
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            var laboratory = new Laboratory()
            {
                Perfomance = perfomance,
            };

            using (var db = factory.CreateContext())
            {
                laboratory.UseMaterial = await db.Materials.SingleAsync(s => s.Id == (comboBox1.SelectedItem as Material).Id);
                laboratory.StaffHeadQuaters = await db.StaffHeadQuaters.SingleAsync(s => s.Id == (comboBox_EmployeeStaff.SelectedItem as StaffHeadQuaters).Id);

                await db.Laboratories.AddAsync(laboratory);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button_ToNavigate_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
