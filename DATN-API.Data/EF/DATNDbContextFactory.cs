using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DATN_API.Data.EF
{
    public class DATNDbContextFactory : IDesignTimeDbContextFactory<DATNDbContext>
    {
        public DATNDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DATNDb");

            var optionsBuilder = new DbContextOptionsBuilder<DATNDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DATNDbContext(optionsBuilder.Options);
        }
    }
}
