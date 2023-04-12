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
    public partial class AuthForm : Form
    {
        private readonly DatabaseFactory factory;

        public AuthForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }

        private void button_CancelAuth_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void button_EnterAuth_Click(object sender, EventArgs e)
        {

        }

        private async void button_EnterAuth_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_LoginAuth.Text) ||
                string.IsNullOrWhiteSpace(textBox_PasswordAuth.Text)
            )
            {
                MessageBox.Show("Введите данные");
                return;
            }

            using (var c = factory.CreateContext())
            {
                if (! await c.Users.AnyAsync(u => u.Login == textBox_LoginAuth.Text && u.Password == textBox_PasswordAuth.Text ))
                {
                    MessageBox.Show("Неизвестный логин или неверный пароль");
                    return;
                }
            }

            Program.IsAuth = true;

            Close();
            Dispose();
        }
    }
}
