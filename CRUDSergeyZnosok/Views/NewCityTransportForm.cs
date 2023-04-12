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
    public partial class NewCityTransportForm : Form
    {
        private readonly DatabaseFactory factory;

        public NewCityTransportForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }

        private async void NewCityTransportForm_Load(object sender, EventArgs e)
        {
            using (var db = factory.CreateContext())
            {
                comboBox_TypeTransport.Items.AddRange(await db.TypeOfTransports.ToArrayAsync());
                comboBox_UsedRoute.Items.AddRange(await db.Routes.ToArrayAsync());
            }
        }

        private async void button_AddCityTransport_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_NumberCityTransport.Text) ||
                comboBox_UsedRoute.SelectedItem is not Route ||
                comboBox_TypeTransport.SelectedItem is not TypeOfTransport
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            using (var db = factory.CreateContext())
            {
                var transport = new Transport()
                {
                    Name = textBox_NumberCityTransport.Text,
                    Route = await db.Routes.SingleAsync(r => r.Id == (comboBox_UsedRoute.SelectedItem as Route).Id),
                    Type = await db.TypeOfTransports.SingleAsync(t => t.Id == (comboBox_TypeTransport.SelectedItem as TypeOfTransport).Id)
                };

                await db.Transports.AddAsync(transport);

                await db.SaveChangesAsync();
            }

            Close();
            Dispose();
        }
    }
}
