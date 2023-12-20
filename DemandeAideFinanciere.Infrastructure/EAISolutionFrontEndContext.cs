using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using DemandeAideFinanciere.Core;
using DemandeAideFinanciere.Core.Entities;

namespace DemandeAideFinanciere.Infrastructure
{
    public class DemandeAideFinanciereContext : DbContext
    {

        public DbSet<Etudiant> Etudiants { get; set; }

        public DbSet<EtudiantFict> EtudiantFicts { get; set; }

        public DbSet<DemandeAideFinanciereForm> DemandeAideFinanciereForms { get; set; }
        public DemandeAideFinanciereContext(DbContextOptions options) : base(options) { }
        public DemandeAideFinanciereContext() : base(new DbContextOptionsBuilder<DemandeAideFinanciereContext>()
                    .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DemandeAideFinanciereBD;Trusted_Connection=True;")
                    .Options)
        { }

    }

}
