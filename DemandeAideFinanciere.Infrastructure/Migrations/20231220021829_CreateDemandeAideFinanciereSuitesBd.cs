using Microsoft.EntityFrameworkCore.Migrations;

namespace DemandeAideFinanciere.Infrastructure.Migrations
{
    public partial class CreateDemandeAideFinanciereSuitesBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DemandeAideFinanciereForms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom_etablissement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code_etablissement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code_programme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_credit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etat_matrimoniale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_debut_etat_matrimoniale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtudiantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandeAideFinanciereForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DemandeAideFinanciereForms_Etudiants_EtudiantId",
                        column: x => x.EtudiantId,
                        principalTable: "Etudiants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EtudiantFicts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code_permanent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtudiantFicts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemandeAideFinanciereForms_EtudiantId",
                table: "DemandeAideFinanciereForms",
                column: "EtudiantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemandeAideFinanciereForms");

            migrationBuilder.DropTable(
                name: "EtudiantFicts");
        }
    }
}
