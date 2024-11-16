using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGestion_Livres
{
    internal class Revue : Livres
    {
        public int Numero { get; set; }
        public int Annee { get; set; }
        public Revue(string titre, string auteur, int nombrePages, int numero, int annee)
            : base(titre, auteur, nombrePages)
        {
            Numero = numero;
            Annee = annee;
        }
        public new void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Numéro : {Numero}, Année : {Annee}");
        }

    }
}
