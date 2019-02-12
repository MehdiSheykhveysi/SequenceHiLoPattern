using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace SequenceHiloPattern.DataBase.Context
{
    internal class SequenceHiloDbContextFactory : IDesignTimeDbContextFactory<SequenceHiloContext>
    {
        public static string _connectionString { get; private set; }

        public SequenceHiloContext CreateDbContext(string[] args)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }

            var builder = new DbContextOptionsBuilder<SequenceHiloContext>();
            builder.UseSqlServer(_connectionString);

            return new SequenceHiloContext(builder.Options);
        }
        private static void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
    }
}
