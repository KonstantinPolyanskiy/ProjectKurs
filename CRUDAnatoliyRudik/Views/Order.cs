using AnatoliyRudik.Database;
using MaterialSkin.Controls;
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

namespace AnatoliyRudik.Views
{
    public partial class Order : MaterialForm
    {
        private readonly DatabaseFactory factory;

        public Order(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }

        private async void Order_Load(object sender, EventArgs e)
        {
            using (var c = factory.CreateContext())
            {
                materialComboBox1.Items.AddRange(await c.Packages.ToArrayAsync());
                materialComboBox2.Items.AddRange(await c.Tariffs.ToArrayAsync());
                materialComboBox3.Items.AddRange(await c.Clients.ToArrayAsync());
                materialComboBox4.Items.AddRange(await c.Operators.ToArrayAsync());
                materialComboBox5.Items.AddRange(await c.TransportDeliveries.ToArrayAsync());
            }
        }

        private void materialButton2_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            Dispose();
        }

        private async void materialButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(materialMultiLineTextBox21.Text) ||
                materialComboBox1.SelectedItem is not Database.Package ||
                 materialComboBox2.SelectedItem is not Tariff ||
                  materialComboBox3.SelectedItem is not Client ||
                   materialComboBox4.SelectedItem is not Operator ||
                    materialComboBox5.SelectedItem is not TransportDelivery
            )
            {
                MessageBox.Show("Заполните анекту");
                return;
            }

            using (var c = factory.CreateContext())
            {
                var package = await c.Packages.SingleAsync(p => p.Id == (materialComboBox1.SelectedItem as Database.Package).Id);
                var tariff = await c.Tariffs.SingleAsync(p => p.Id == (materialComboBox2.SelectedItem as Tariff).Id);
                var client = await c.Clients.SingleAsync(p => p.Id == (materialComboBox3.SelectedItem as Client).Id);
                var @operator = await c.Operators.SingleAsync(p => p.Id == (materialComboBox4.SelectedItem as Operator).Id);
                var transport = await c.TransportDeliveries.SingleAsync(p => p.Id == (materialComboBox5.SelectedItem as TransportDelivery).Id);

                var order = new Database.Order()
                {
                    Address = materialMultiLineTextBox21.Text,
                    Client = client,
                    Delivery = transport,
                    Operator = @operator,
                    Package = package,
                    Tariff = tariff
                };

                await c.Orders.AddAsync(order);

                await c.SaveChangesAsync();
            }

            Close();
            Dispose();
        }
    }
}
