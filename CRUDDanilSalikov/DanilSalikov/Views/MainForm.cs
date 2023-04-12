
using DanilSalikov.Database;
using DanilSalikov.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Windows.Forms.VisualStyles;

namespace DanilSalikov
{
    public partial class MainForm : Form
    {
        private readonly DatabaseFactory _factory;
        private Door[] availableDoors;

        public MainForm(DatabaseFactory factory)
        {
            _factory = factory;

            InitializeComponent();

            UpdateDataGridView();
        }

        private async void UpdateDataGridView(Func<IQueryable<Door>, IQueryable<Door>>? filter = null)
        {
            using (var db = _factory.CreateContext())
            {
                IQueryable<Door> availableDoors =
                    db.Doors
                    .Include(d => d.Manufacturer)
                    .Include(d => d.Category)
                    .Include(d => d.Material);

                if (filter != null) availableDoors = filter(availableDoors);

                this.availableDoors = await availableDoors.ToArrayAsync();
            }

            DataGridViewDoors.DataSource = this.availableDoors;
        }

        private void ButtonAddDoor_MouseClick(object sender, MouseEventArgs e)
        {
            new AddDoorForm(_factory).ShowDialog();

            UpdateDataGridView();
        }

        private void ButtonEditDoor_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridViewDoors.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Вы не выбрали дверь");
                return;
            }

            new EditDoorForm(_factory, availableDoors[DataGridViewDoors.SelectedRows[0].Index].Id).ShowDialog();

            UpdateDataGridView();
        }

        private async void ButtonDeleteDoor_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridViewDoors.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Вы не выбрали дверь");
                return;
            }

            using (var db = _factory.CreateContext())
            {
                var door = await db.Doors
                    .Include(d => d.Manufacturer)
                    .Include(d => d.Category)
                    .Include(d => d.Material)
                    .SingleAsync(d => d.Id == availableDoors[DataGridViewDoors.SelectedRows[0].Index].Id);

                db.Doors.Remove(door);

                await db.SaveChangesAsync();
            }

            UpdateDataGridView();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearch.Text;

            if (string.IsNullOrWhiteSpace(text)) UpdateDataGridView();

            UpdateDataGridView
            (
                d => d.Where(door => door.Name.Contains(text) ||
                        door.Manufacturer.Name.Contains(text) ||
                        door.Category.Name.Contains(text) ||
                        door.Price.ToString().Contains(text) ||
                        door.Material.Name.Contains(text) ||
                        door.Description.Contains(text))
            );
        }

        private void ButtonClear_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSearch.Text = string.Empty;
        }

        private async void button6_MouseClick(object sender, MouseEventArgs e)
        {
            Material[] array;
            using (var db = _factory.CreateContext())
            {
                array = await db.Materials.ToArrayAsync();
            }

            new ViewTableForm(array, "материалы").ShowDialog();
        }

        private async void button5_MouseClick(object sender, MouseEventArgs e)
        {
            Manufacturer[] array;
            using (var db = _factory.CreateContext())
            {
                array = await db.Manufacturers.ToArrayAsync();
            }

            new ViewTableForm(array, "производители").ShowDialog();
        }

        private async void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Category[] array;
            using (var db = _factory.CreateContext())
            {
                array = await db.Categories.ToArrayAsync();
            }

            new ViewTableForm(array, "категории").ShowDialog();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            new AddMaterial(_factory).ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            new AddManufacturer(_factory).ShowDialog();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            new AddCategory(_factory).ShowDialog();
        }
    }
}
