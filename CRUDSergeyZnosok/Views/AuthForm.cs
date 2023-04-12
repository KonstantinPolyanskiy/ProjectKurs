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
    public partial class AuthForm : Form
    {
        private readonly DatabaseFactory factory;
        public AuthForm(DatabaseFactory factory)
        {
            InitializeComponent();

            this.factory = factory;
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        private async void button_Enter_MouseClick(object sender, MouseEventArgs e)
        {
            if
            (
                string.IsNullOrWhiteSpace(textBox_LoginAuth.Text) ||
                string.IsNullOrWhiteSpace(textBox_PasswordAuth.Text)
            )
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            using (var db = factory.CreateContext())
            {
                if (!await db.Users.AnyAsync(u => u.Login == textBox_LoginAuth.Text && u.Password == textBox_PasswordAuth.Text))
                {
                    MessageBox.Show("Неудачная попытка");
                    return;
                }
            }
            Program.IsAuth = true;
            Close();
            Dispose();
        }
    }
}
