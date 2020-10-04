using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VuonSenDaShop.Data.EF
{
    public class VuonSenDaShopDbContextFactory : IDesignTimeDbContextFactory<VuonSenDaShopDbContext>
    {
        public VuonSenDaShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectionString = configurationRoot.GetConnectionString("VuonSenDaShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<VuonSenDaShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new VuonSenDaShopDbContext(optionsBuilder.Options);
        }
    }
}
