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
using static System.Formats.Asn1.AsnWriter;

namespace ZnosokKurs.Views
{
    public partial class NewRouteForm : Form
    {
        private readonly DatabaseFactory factory;

        public NewRouteForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;

            using (var db = factory.CreateContext())
            {
                listBox_AllStops.Items.AddRange(db.Stops.ToArray());
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_AllStops.SelectedItem is not Stop) return;

            listBox_RouteStops.Items.Add(listBox_AllStops.SelectedItem);
            listBox_AllStops.Items.Remove(listBox_AllStops.SelectedItem);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox_RouteStops.SelectedItem is not Stop) return;

            listBox_AllStops.Items.Add(listBox_RouteStops.SelectedItem);
            listBox_RouteStops.Items.Remove(listBox_RouteStops.SelectedItem);
        }

        private async void button_AddRoute_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_RouteName.Text) ||
                ! int.TryParse(textBox_RouteLength.Text, out int @long) ||
                listBox_RouteStops.Items.Count == 0
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            var route = new Route()
            {
                Long = @long,
                Name = textBox_RouteName.Text,
                Stops = new List<Stop>(listBox_RouteStops.Items.Count)
            };

            using (var db = factory.CreateContext())
            {
                foreach (var stop in listBox_RouteStops.Items.Cast<Stop>())
                {
                    route.Stops.Add( await db.Stops.SingleAsync(s => s.Id == stop.Id) );
                }

                await db.Routes.AddAsync(route);

                await db.SaveChangesAsync();
            }

            Close();
            Dispose();
        }
    }
}
