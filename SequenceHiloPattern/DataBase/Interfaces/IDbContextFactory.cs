using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SequenceHiloPattern.DataBase.Interfaces
{
    public interface IDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T:DbContext
    {
         string _connectionString { get; set; }


         void LoadConnectionString();

        /// <summary>
        /// In its Impelimentations Pass Null For Method CreateDbContext(string[] args)
        /// </summary>
        /// <returns></returns>
        T CreateDbContext();
    }
}
