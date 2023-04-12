using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;
using MaterialSkin;
using AnatoliyRudik.Database;
using Microsoft.EntityFrameworkCore;

namespace AnatoliyRudik.Views
{
    public partial class MainForm : MaterialForm
    {
        private readonly DatabaseFactory factory;

        private async Task UpdateDataGridView()
        {
            using (var c = factory.CreateContext())
            {
                dataGridView1.DataSource = await c.Operators.ToArrayAsync();
            }
        }

        private async Task UpdateAllOrders()
        {
            listBoxAvailableOrders.Items.Clear();

            using (var c = factory.CreateContext())
            {
                foreach (var order in await c.Orders.ToArrayAsync())
                {
                    listBoxAvailableOrders.Items.Add(new MaterialListBoxItem(order.ToString()));
                }
            }
        }

        private async Task UpdateAllTariffs()
        {
            materialListBoxAvailableTariffs.Items.Clear();

            using (var c = factory.CreateContext())
            {
                foreach (var tariff in await c.Tariffs.ToArrayAsync())
                {
                    materialListBoxAvailableTariffs.Items.Add(new MaterialListBoxItem(tariff.ToString()));
                }
            }
        }

        private async Task UpdateAllDeliveries()
        {
            materialListBoxAvailableDeliverily.Items.Clear();

            using (var c = factory.CreateContext())
            {
                foreach (var delivery in await c.TransportDeliveries.ToArrayAsync())
                {
                    materialListBoxAvailableDeliverily.Items.Add(new MaterialListBoxItem(delivery.ToString()));
                }
            }

            if (listBoxAvailableOrders.Items.Count > 0) materialButton1.Enabled = true;
            else materialButton1.Enabled = false;
        }

        public MainForm(DatabaseFactory factory)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            this.factory = factory;

            UpdateDataGridView();
            UpdateAllOrders();
            UpdateAllTariffs();
            UpdateAllDeliveries();
        }

        private async void materialButtonCreateOrder_MouseClick(object sender, MouseEventArgs e)
        {
            new Order(factory).ShowDialog(this);

            await UpdateAllOrders();
        }

        private void materialButton2_MouseClick(object sender, MouseEventArgs e)
        {
            new Package(factory).ShowDialog(this);
        }

        private async void materialListBoxAvailableTariffs_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            using (var c = factory.CreateContext())
            {
                var tariff = await c.Tariffs.SingleAsync(t => t.Name == materialListBoxAvailableTariffs.SelectedItem.Text);

                materialLabel14.Text = $"Название \"{tariff.Name}\"";
                materialLabel15.Text = $"Стоимость {tariff.Price} рублей";
            }

        }

        private async void materialListBoxAvailableDeliverily_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            using (var c = factory.CreateContext())
            {
                var deliverily = await c.TransportDeliveries.SingleAsync(t => t.Name == materialListBoxAvailableDeliverily.SelectedItem.Text);

                materialLabel17.Text = $"Название \"{deliverily.Name}\"";
                materialMultiLineTextBox1.Text = $"{deliverily.Address}";
            }
        }

        private async void materialButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text)
            )
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            var @operator = new Operator()
            {
                Email = textBox3.Text,
                Surname = textBox4.Text,
                LastName = textBox6.Text,
                Name = textBox5.Text,
                Phone = textBox2.Text
            };

            using (var c = factory.CreateContext())
            {
                await c.Operators.AddAsync(@operator);

                await c.SaveChangesAsync();
            }

            await UpdateDataGridView();
        }

        private async void listBoxAvailableOrders_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            materialButton1.Enabled = true;

            using (var c = factory.CreateContext())
            {
                var order = await c.Orders
                    .Include(o => o.Tariff)
                    .Include(o => o.Client)
                    .Include(o => o.Delivery)
                    .Include(o => o.Operator)
                    .Include(o => o.Package)
                    .SingleAsync(d => d.Id == int.Parse(listBoxAvailableOrders.SelectedItem.Text));

                materialLabel1.Text = $"Код заказа: {order.Id}";
                materialLabel2.Text = $"Код посылки: {order.Package.Id}";
                materialLabel3.Text = $"Тип доставки: {order.Tariff.Name}";
                materialLabel4.Text = $"Клиент: {order.Client.ToString()}";
                materialLabel5.Text = $"Оператор: {order.Operator.ToString()}";
                materialLabel6.Text = $"Адрес доставки: {order.Address}";
                materialLabel7.Text = $"Доставка: {order.Delivery.ToString()}";
            }
        }

        private async void materialButton1_MouseClick(object sender, MouseEventArgs e)
        {
            using (var c = factory.CreateContext())
            {
                var order = await c.Orders
                    .SingleAsync
                    (d => d.Id == int.Parse(listBoxAvailableOrders.SelectedItem.Text));

                c.Orders.Remove(order);

                await c.SaveChangesAsync();
            }

            await UpdateAllOrders();

            MessageBox.Show("Заказ закрыт.");
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var c = factory.CreateContext())
            {
                dataGridView1.DataSource = await c.Operators
                    .Where
                    (
                        op => op.Surname.Contains(textBox1.Text) ||
                        op.Name.Contains(textBox1.Text) ||
                        op.LastName.Contains(textBox1.Text) ||
                        op.Id.ToString().Contains(textBox1.Text) ||
                        op.Email.Contains(textBox1.Text) ||
                        op.Phone.Contains(textBox1.Text)
                    )
                    .ToArrayAsync();
            }
        }
    }
}
