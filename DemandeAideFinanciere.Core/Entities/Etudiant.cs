using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using DemandeAideFinanciere.SharedKernel;
using DemandeAideFinanciere.SharedKernel.Interfaces;

namespace DemandeAideFinanciere.Core
{
    public class Etudiant : BaseEntity, IAggregateRoot
    {

        public string Password { get; set; } = string.Empty;

        public string Nas {  get; set; } = string.Empty;

        public string Code_permanent { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;

        public Etudiant()
        {
            // exigé par EF
        }

        public Etudiant( string password, string nas, string code_permanent, string birthday)
        {
        //    FirstName = firstName;
        //    LastName = lastName;
            Password = password;
            Nas = nas;
            Code_permanent = code_permanent;
            Birthday = birthday;

        }

    }
}
