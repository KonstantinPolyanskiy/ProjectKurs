using ZnosokKurs.Views;
using ZnosokKurs.Database;
using Microsoft.EntityFrameworkCore;

namespace ZnosokKurs
{
    internal static class Program
    {
        public static bool IsAuth = false;

        [STAThread]
        static async Task Main()
        {
            DatabaseFactory factory = new DatabaseFactory
            (
                optionsBuilder => optionsBuilder
                    .UseSqlServer("Data Source=DESKTOP-2VVQ0T3\\SQLEXPRESS;Initial Catalog=БазаМаршрутов;Integrated Security=True;TrustServerCertificate=True")
            );

            using (var db = factory.CreateContext()) await db.Database.EnsureCreatedAsync();

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm(factory));

            if (IsAuth)
            {
                Application.Run(new MainForm(factory));
            }
        }
    }
}