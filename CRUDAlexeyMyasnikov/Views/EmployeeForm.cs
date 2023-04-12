using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmKurs.Database;
using Microsoft.EntityFrameworkCore;

namespace FarmKurs.Views
{
    public partial class EmployeeForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridViewStaffHeadQuaters()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView1.DataSource = await db.StaffHeadQuaters.Include(s => s.ManagerEmployeer).ToArrayAsync();
            }
        }

        private async Task UpdateDataGridViewEmployeers()
        {
            using (var db = factory.CreateContext())
            {
                Employeer[] arr = await db.Employeers.ToArrayAsync();

                dataGridView2.DataSource = arr;

                listBox_Employes.Items.Clear();
                listBox_Employes.Items.AddRange(arr);

                comboBoxManagerEmployeer.Items.Clear();
                comboBoxManagerEmployeer.Items.AddRange(arr);
            }
        }

        public EmployeeForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridViewEmployeers();
            UpdateDataGridViewStaffHeadQuaters();
        }

        private async void button_AddEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            string[] fullName = textBox_NameEmployer.Text.Split(' ');

            if
            (
                fullName.Length != 3 ||
                string.IsNullOrWhiteSpace(textBox_EmployeePosition.Text) ||
                !decimal.TryParse(textBox_SalaryEmployee.Text, out decimal salary)
            )
            {
                MessageBox.Show("Заполните корректно форму");
                return;
            }

            var employeer = new Employeer()
            {
                Salary = salary,
                Position = textBox_EmployeePosition.Text,
                Name = fullName[1],
                Surname = fullName[0],
                LastName = fullName[2]
            };

            using (var db = factory.CreateContext())
            {
                await db.Employeers.AddAsync(employeer);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridViewEmployeers();
        }

        private void button_ClearEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_EmployeePosition.Text = string.Empty;
            textBox_NameEmployer.Text = string.Empty;
            textBox_SalaryEmployee.Text = string.Empty;
        }

        private async void button_DeleteEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count < 1) return;

            int index = dataGridView2.SelectedRows[0].Index;

            using (var db = factory.CreateContext())
            {
                db.Employeers.Remove((dataGridView2.DataSource as Employeer[])[index]);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridViewStaffHeadQuaters();
            await UpdateDataGridViewEmployeers();
        }

        private void button_CancelStaffEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxManagerEmployeer.SelectedIndex = -1;
            listBox_Employes.SelectedItems.Clear();
        }

        private async void button_AddStaffEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                comboBoxManagerEmployeer.SelectedItem is not Employeer ||
                listBox_Employes.SelectedItems.Count < 1
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            var staffHeadQuaters = new StaffHeadQuaters()
            {
                Employeers = new List<Employeer>()
            };

            using (var db = factory.CreateContext())
            {
                foreach (var employeer in listBox_Employes.SelectedItems.Cast<Employeer>())
                {
                    staffHeadQuaters.Employeers.Add(await db.Employeers.SingleAsync(e => e.Id == employeer.Id));
                }

                staffHeadQuaters.ManagerEmployeer = await db.Employeers.SingleAsync(e => e.Id == (comboBoxManagerEmployeer.SelectedItem as Employeer).Id);

                await db.StaffHeadQuaters.AddAsync(staffHeadQuaters);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridViewStaffHeadQuaters();
        }

        private void button_ToNavigate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void button_DeleteStaffEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            int index = dataGridView1.SelectedRows[0].Index;

            using (var db = factory.CreateContext())
            {
                db.StaffHeadQuaters.Remove((dataGridView1.DataSource as StaffHeadQuaters[])[index]);

                await db.SaveChangesAsync();
            }

            await UpdateDataGridViewStaffHeadQuaters();
        }
    }
}
