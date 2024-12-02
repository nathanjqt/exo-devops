using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Compte : ICustomer, IBanker
    {
        public void Retrait(double Montant)
        {
            Solde -= Montant;
        }
        public void Depot(double Montant)
        {
            Solde += Montant;
        }
    }
}
