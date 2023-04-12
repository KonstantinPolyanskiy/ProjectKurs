using AnatoliyRudik.Database;
using MaterialSkin.Controls;
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
    public partial class Package : MaterialForm
    {
        private readonly DatabaseFactory factory;

        public Package(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
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
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) ||
                !double.TryParse(textBox6.Text, out double size) ||
                !double.TryParse(textBox7.Text, out double weight)
            )
            {
                MessageBox.Show("Заполните анкету");
                return;
            }

            using (var c = factory.CreateContext())
            {
                var client = new Client()
                {
                    Phone = textBox1.Text,
                    Email = textBox3.Text,
                    Surname = textBox2.Text,
                    Name = textBox4.Text,
                    LastName = textBox5.Text,
                };

                var package = new Database.Package()
                {
                    Size = size,
                    Weight = weight,
                    TrackNumber = textBox8.Text
                };

                await c.Clients.AddAsync(client);
                await c.Packages.AddAsync(package);

                await c.SaveChangesAsync();
            }

            Close();
            Dispose();
        }
    }
}
