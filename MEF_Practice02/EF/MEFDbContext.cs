using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace MEF_Practice02.EF
{
    public partial class MEFDbContext : DbContext
    {
        public MEFDbContext(DbContextOptions<MEFDbContext> options) : base(options)
        {

        }

        public virtual DbSet<TypeAssemblyFile> TypeAssemblyFiles { get; set; }
    }

    public partial class MEFDbContext : DbContext
    {
        private static readonly string _connectionString =
            "Server=.\\mssql2017;Database=MEF_Practice;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static MEFDbContext CreateInstance()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MEFDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            var result = new MEFDbContext(optionsBuilder.Options);
            return result;
        }
    }
}
