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
    public partial class JournalsForm : Form
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var c = factory.CreateContext())
            {
                dataGridViewJournals.DataSource = await c.Journals.ToArrayAsync();
            }
        }

        public JournalsForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            UpdateDataGridView();
        }

        private async void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите название журнала");
                return;
            }

            var journal = new Journal()
            {
                CreatedAt = dateTimePicker1.Value,
                Name = textBox1.Text
            };

            using (var c = factory.CreateContext())
            {
                await c.Journals.AddAsync(journal);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;

            dataGridViewJournals.ClearSelection();
        }

        private void dataGridViewJournals_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewJournals.SelectedRows.Count < 1) return;

            int index = dataGridViewJournals.SelectedRows[0].Index;

            var journal = (dataGridViewJournals.DataSource as Journal[])[index];

            textBox1.Text = journal.Name;
            dateTimePicker1.Value = journal.CreatedAt;
        }

        private async void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите название журнала");
                return;
            }

            if (dataGridViewJournals.SelectedRows.Count < 1) return;

            int index = dataGridViewJournals.SelectedRows[0].Index;

            var journal = (dataGridViewJournals.DataSource as Journal[])[index];

            using (var c = factory.CreateContext())
            {
                journal = await c.Journals.SingleAsync(j => j.Id == journal.Id);

                journal.Name = textBox1.Text;
                journal.CreatedAt = dateTimePicker1.Value;

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }
    }
}
