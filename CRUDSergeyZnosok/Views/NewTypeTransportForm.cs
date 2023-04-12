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
    public partial class NewTypeTransportForm : Form
    {
        private readonly DatabaseFactory factory;

        public NewTypeTransportForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }

        private void button_CancelTypeTransport_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void button_AddTypeTransport_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_TransportName.Text) ||
                string.IsNullOrWhiteSpace(richTextBox_TransportCharacteristic.Text)
            )
            {
                MessageBox.Show("Введите данные");
                return;
            }
            var type = new TypeOfTransport()
            {
                Name = textBox_TransportName.Text,
                Description = richTextBox_TransportCharacteristic.Text
            };
            using (var db = factory.CreateContext())
            {
                await db.TypeOfTransports.AddAsync(type);
                await db.SaveChangesAsync();
            }
            this.Close();
            this.Dispose();
        }
    }
}
