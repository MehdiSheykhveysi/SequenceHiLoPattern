using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SequenceHiloPattern.DataBase.Interfaces;

namespace SequenceHiloPattern.DataBase.Context
{
    public class UseSequenceDbContextFactory : IDbContextFactory<UseSequenceDbContext>
    {
        public string _connectionString { get; set; }

        public UseSequenceDbContext CreateDbContext(string[] args)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }
            var builder = new DbContextOptionsBuilder<UseSequenceDbContext>();
            builder.UseSqlServer(_connectionString);
            return new UseSequenceDbContext(builder.Options);
        }

        public UseSequenceDbContext CreateDbContext()
        {
            return CreateDbContext(null);
        }

        public void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
    }
}