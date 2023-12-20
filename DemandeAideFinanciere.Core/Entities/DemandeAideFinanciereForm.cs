using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemandeAideFinanciere.SharedKernel;


namespace DemandeAideFinanciere.Core
{
    public class DemandeAideFinanciereForm
    {
        public string Id { get; set; }
        public string Nom_etablissement { get; set; } = string.Empty;
        public string Code_etablissement { get; set; } = string.Empty;
        public string Code_programme { get; set; } = string.Empty;
        public string Nombre_credit { get; set; } = string.Empty;
        public string Etat_matrimoniale { get; set; } = string.Empty;
        public string Date_debut_etat_matrimoniale { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
        public DemandeAideFinanciereForm()
        {
            // exigé par EF
        }
        public Etudiant Etudiant { get; set; }

        public DemandeAideFinanciereForm(Etudiant etudiant)
        {
            Etudiant = etudiant;
        }

        public DemandeAideFinanciereForm(string nom_etablissement, string code_etablissement, string code_programme, string nombre_credit, string etat_matrimoniale, string date_debut_etat_matrimoniale, string status)
        {
            Nom_etablissement = nom_etablissement;
            Code_etablissement = code_etablissement;
            Code_programme = code_programme;
            Nombre_credit = nombre_credit;
            Etat_matrimoniale = etat_matrimoniale;
            Date_debut_etat_matrimoniale = date_debut_etat_matrimoniale;
            Status = status;
        }
    }
}
