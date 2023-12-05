using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandeAideFinanciere.Core
{
    public class DemandeAideFinanciere
    {
        public string Nom_etablissement { get; set; }
        public string Code_etablissement {  set; get; }

        public string Code_programme { get; set; }

        public string Nombre_credit { get; set; }

        public string Etat_matrimoniale { get; set; }

        public string Date_debut_etat_matrimoniale {  set; get; }


    }
}
