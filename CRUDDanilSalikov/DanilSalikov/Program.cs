
using DanilSalikov.Database;
using Microsoft.EntityFrameworkCore;

namespace DanilSalikov
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var factory = new DatabaseFactory(setup => setup.UseSqlServer("Data Source=DESKTOP-2VVQ0T3\\SQLEXPRESS;Initial Catalog=КаталогДверей;Integrated Security=True;TrustServerCertificate=True"));

           using (var c = factory.CreateContext())
           {
                c.Database.EnsureCreated();
           }
            
            ApplicationConfiguration.Initialize();

            Application.Run(new MainForm(factory));
        }
    }
}