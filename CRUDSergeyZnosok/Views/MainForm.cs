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
using ZnosokKurs.Database;

namespace ZnosokKurs.Views
{
    public partial class MainForm : Form
    {
        private readonly DatabaseFactory factory;

        private int? GetIndexFromDataGridView(DataGridView dataGrid)
        {
            if (dataGrid.SelectedRows.Count < 1) return null;

            return dataGrid.SelectedRows[0].Index;
        }

        private T[] GetDataSource<T>(DataGridView dataGrid) => dataGrid.DataSource as T[];

        private async Task UpdateTypesTransportAsync()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_TypeTransport.DataSource = await db.TypeOfTransports.ToArrayAsync();
            }
        }

        private async Task UpdateUsersAsync()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_Users.DataSource = await db.Users.ToArrayAsync();
            }
        }

        private async Task UpdateRoutesAsync()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_Route.DataSource = await db.Routes.ToArrayAsync();
            }
        }

        private async Task UpdateTransportAsync()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_CityTransport.DataSource = await db.Transports.Include(t => t.Route).Include(t => t.Type).ToArrayAsync();
            }
        }

        private async Task UpdateStopsAsync()
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_BusStops.DataSource = await db.Stops.ToArrayAsync();
            }
        }

        private async Task UpdateScheduleTransport(int transportId)
        {
            using (var db = factory.CreateContext())
            {
                dataGridView_RouteTimeTable.DataSource =
                    await db.Schedules.Where(s => s.Transport.Id == transportId).Include(s => s.Transport).ToArrayAsync();
            }
        }

        public MainForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            groupBoxSchedule.Enabled = false;

            UpdateTypesTransportAsync();
            UpdateTransportAsync();
            UpdateStopsAsync();
            UpdateRoutesAsync();
            UpdateUsersAsync();
        }

        private async void button_AddTypeTransport_MouseClick(object sender, MouseEventArgs e)
        {
            new NewTypeTransportForm(factory).ShowDialog();

            await UpdateTypesTransportAsync();
        }

        private async void button_DeleteTypeTransport_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_TypeTransport);

            if (index is null) return;

            using (var db = factory.CreateContext())
            {

                db.TypeOfTransports.Remove(GetDataSource<TypeOfTransport>(dataGridView_TypeTransport)[index.Value]);

                await db.SaveChangesAsync();
            }

            await UpdateTypesTransportAsync();
        }

        private async void button_DeleteCityTransport_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_CityTransport);

            if (index is null) return;

            using (var db = factory.CreateContext())
            {
                db.Transports.Remove(GetDataSource<Transport>(dataGridView_CityTransport)[index.Value]);

                await db.SaveChangesAsync();
            }

            await UpdateTransportAsync();

            if (dataGridView_CityTransport.Rows.Count < 1)
            {
                groupBoxSchedule.Enabled = false;
            }
        }

        private async void button_AddCityTransport_MouseClick(object sender, MouseEventArgs e)
        {
            new NewCityTransportForm(factory).ShowDialog();

            await UpdateTransportAsync();
        }

        private async void dataGridView_CityTransport_SelectionChanged(object sender, EventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_CityTransport);

            if (index is null) return;
            groupBoxSchedule.Enabled = true;

            var transport = GetDataSource<Transport>(dataGridView_CityTransport)[index.Value];

            await UpdateScheduleTransport(transport.Id);
        }

        private async void button_AddOrSaveRouteTime_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_CityTransport);

            if (index is null) return;

            var transport = GetDataSource<Transport>(dataGridView_CityTransport)[index.Value];

            using (var db = factory.CreateContext())
            {
                var schedule = new Schedule()
                {
                    Transport = await db.Transports.SingleAsync(t => t.Id == transport.Id),
                    TimeFromEnd = TimeOnly.FromDateTime(dateTimePicker_TimeEndPoint.Value).ToTimeSpan(),
                    TimeFromStart = TimeOnly.FromDateTime(dateTimePicker_TimeStartPoint.Value).ToTimeSpan(),
                };

                await db.Schedules.AddAsync(schedule);

                await db.SaveChangesAsync();
            }

            await UpdateScheduleTransport(transport.Id);
        }

        private async void button_DeleteEditBusStop_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_RouteTimeTable);
            var indexTransport = GetIndexFromDataGridView(dataGridView_CityTransport);

            if (index is null || indexTransport is null) return;

            var schedule = GetDataSource<Schedule>(dataGridView_RouteTimeTable)[index.Value];
            var transport = GetDataSource<Transport>(dataGridView_CityTransport)[indexTransport.Value];

            using (var db = factory.CreateContext())
            {
                db.Schedules.Remove(schedule);

                await db.SaveChangesAsync();
            }

            await UpdateScheduleTransport(transport.Id);
        }

        private async void button_AddOrSaveBusStop_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_Street.Text) ||
                string.IsNullOrWhiteSpace(textBox_NameBusStop.Text) ||
                string.IsNullOrWhiteSpace(textBox_longitude.Text) ||
                string.IsNullOrWhiteSpace(textBox_latitude.Text) ||
                !double.TryParse(textBox_latitude.Text, out double latitude) ||
                !double.TryParse(textBox_longitude.Text, out double longitude)
            )
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            using (var db = factory.CreateContext())
            {
                var stop = new Stop()
                {
                    Street = textBox_Street.Text,
                    Name = textBox_NameBusStop.Text,
                    Latitude = latitude,
                    Longitude = longitude
                };

                await db.Stops.AddAsync(stop);

                await db.SaveChangesAsync();
            }

            await UpdateStopsAsync();
        }

        private async void button_DeleteBusStop_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_BusStops);

            if (index is null) return;

            var stop = GetDataSource<Stop>(dataGridView_BusStops)[index.Value];

            using (var db = factory.CreateContext())
            {
                db.Stops.Remove(stop);

                await db.SaveChangesAsync();
            }

            await UpdateStopsAsync();
        }

        private async void button_DeleteRoute_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_Route);

            if (index is null) return;

            var route = GetDataSource<Route>(dataGridView_Route)[index.Value];

            using (var db = factory.CreateContext())
            {
                db.Routes.Remove(route);

                await db.SaveChangesAsync();
            }

            await UpdateRoutesAsync();
        }

        private async void button_AddRoute_MouseClick(object sender, MouseEventArgs e)
        {
            new NewRouteForm(factory).ShowDialog();

            await UpdateRoutesAsync();
        }

        private async void button_AddUser_MouseClick(object sender, MouseEventArgs e)
        {
            string[] fullName = textBox_UserName.Text.Split(' ');

            if
            (
                fullName.Length != 3 ||
                string.IsNullOrWhiteSpace(textBox_UserNumber.Text) ||
                string.IsNullOrWhiteSpace(textBox_LoginUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_PasswordUser.Text) ||
                string.IsNullOrWhiteSpace(textBox_PositionUser.Text)
            )
            {
                MessageBox.Show("Заполните или проверьте информацию");
                return;
            }

            using (var db = factory.CreateContext())
            {
                var user = new User()
                {
                    LastName = fullName[2],
                    Name = fullName[1],
                    Surname = fullName[0],
                    Login = textBox_LoginUser.Text,
                    Password = textBox_PasswordUser.Text,
                    Position = textBox_PositionUser.Text,
                    Phone = textBox_UserNumber.Text
                };

                await db.Users.AddAsync(user);

                await db.SaveChangesAsync();
            }

            await UpdateUsersAsync();
        }

        private async void button_DeleteUser_MouseClick(object sender, MouseEventArgs e)
        {
            var index = GetIndexFromDataGridView(dataGridView_Users);

            if (index is null) return;

            var user = GetDataSource<User>(dataGridView_Users)[index.Value];

            using (var db = factory.CreateContext())
            {
                db.Users.Remove(user);

                await db.SaveChangesAsync();
            }

            await UpdateUsersAsync();
        }
    }
}
