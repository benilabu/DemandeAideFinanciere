using DemandeAideFinanciere.SharedKernel.Interfaces;
using DemandeAideFinanciere.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandeAideFinanciere.Core.Entities
{
    public class EtudiantFict: BaseEntity, IAggregateRoot
    {
        public string Id { get; set; }
        public string Nas { get; set; } = string.Empty;
        public string Code_permanent { get; set; } = string.Empty;

        public string FirstName { get; set; } =string.Empty;

        public string LastName { get; set; } = string.Empty;


        public EtudiantFict()
        {
            // exigé par EF
        }

        public EtudiantFict (string nas, string code_permanent, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Nas = nas;
            Code_permanent = code_permanent;

        }
    }
}
