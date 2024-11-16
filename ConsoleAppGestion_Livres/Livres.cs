using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGestion_Livres
{
    internal class Livres
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }
        public Livres(string titre, string auteur, int nombrePages)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nombrePages;
        }
        public void AfficherDetails()
        {
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Pages : {NombrePages}");
        }
    }
}

