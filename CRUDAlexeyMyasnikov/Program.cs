using FarmKurs.Views;
using FarmKurs.Database;
using Microsoft.EntityFrameworkCore;

namespace FarmKurs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var factory = new DatabaseFactory(setup => setup.UseSqlServer("Data Source=DESKTOP-2VVQ0T3\\SQLEXPRESS;Initial Catalog=ФармацевтическийЗавод;Integrated Security=True;TrustServerCertificate=True"));

            using (var c = factory.CreateContext())
            {
                c.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new NavigateForm(factory));
        }
    }
}