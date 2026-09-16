using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string ConnectionString = "";
        private readonly AppDbContext _appDbContext;
        CompanyDbContext(string companyId, AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            Company company = _appDbContext.Companies.Find(companyId);
            if(company.UserId == "")
            {
                ConnectionString = $"" +
                    $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DataBaseName};" +
                    $"Integrated Security=True;" +
                    $"Connect Timeout=30;" +
                    $"Encrypt=True;" +
                    $"Trust Server Certificate=True;" +
                    $"Application Intent=ReadWrite;" +
                    $"Multi Subnet Failover=False;" +
                    $"Command Timeout=30";
            }
            else
            {
                ConnectionString = $"" +
                    $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DataBaseName};" +
                    $"User ID={company.UserId};" +
                    $"Password={company.Password};" +
                    $"Connect Timeout=30;" +
                    $"Encrypt=True;" +
                    $"Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
