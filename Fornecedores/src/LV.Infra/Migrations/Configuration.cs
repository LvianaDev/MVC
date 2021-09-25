using System.Data.Entity.Migrations;

namespace LV.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}
