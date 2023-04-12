using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnatoliyRudik.Database;
using AnatoliyRudik.Views;
using Microsoft.EntityFrameworkCore;

namespace AnatoliyRudik
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            var factory = new DatabaseFactory(setup => setup.UseSqlServer("Data Source=DESKTOP-2VVQ0T3\\SQLEXPRESS;Initial Catalog=Почта;Integrated Security=True;TrustServerCertificate=True"));

            using (var c = factory.CreateContext())
            {
                c.Database.EnsureCreated();
            }

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(factory));
        }
    }
}
