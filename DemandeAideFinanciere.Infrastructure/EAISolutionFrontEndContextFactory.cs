using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DemandeAideFinanciere.Infrastructure
{
    public class EAISolutionFrontEndContextContextFactory : IDesignTimeDbContextFactory<DemandeAideFinanciereContext>
    {
        public DemandeAideFinanciereContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DemandeAideFinanciereContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DemandeAideFinanciereBD;Trusted_Connection=True;");

            return new DemandeAideFinanciereContext(optionsBuilder.Options);
        }
    }
}
