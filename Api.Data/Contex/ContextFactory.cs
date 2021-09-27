using Api.Data.Contex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        private static string Host = "localhost";
        private static string User = "Junior";
        private static string DBname = "EventDB";
        private static string Password = "123456";
        private static string Port = "5432";

        public MyContext CreateDbContext(string[] args)   // Usado para criar as migrations
        {
            var connectionString = $"Server={Host}; Port={Port}; Database={DBname}; Uid={User}; Pwd={Password}";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
