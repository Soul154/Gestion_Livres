using ConsoleAppGestion_Livres;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans la gestion des livres");
        Livres livre = new Livres("1984", "George Orwell", 328);
        Revue revue = new Revue("Science et Vie", "Collectif", 50, 123, 2024);
        Roman roman = new Roman("Le Seigneur des animaux", "J.R.R. Tolkien", 1200, "Fantasy");

        livre.AfficherDetails();
        Console.WriteLine();
        revue.AfficherDetails();
        Console.WriteLine();
        roman.AfficherDetails();
        // Création des instances de Revue
        Revue revue1 = new Revue("Science et Vie", "Collectif", 100, 125, 2024);
        Revue revue2 = new Revue("National Geographic", "Collectif", 80, 30, 2023);
        Revue revue3 = new Revue("Popular Mechanics", "Collectif", 90, 45, 2022);

        // Affichage des détails
        revue1.AfficherDetails();
        Console.WriteLine();
        revue2.AfficherDetails();
        Console.WriteLine();
        revue3.AfficherDetails();
        // Ajout dans la méthode Main()
        Roman roman1 = new Roman("Dune", "Frank Herbert", 412, "Science-fiction");
        Roman roman2 = new Roman("L'Étranger", "Albert Camus", 124, "Drame");
        Roman roman3 = new Roman("Le Comte de Monte-Cristo", "Alexandre Dumas", 1312, "Aventure");

        // Affichage des détails
        Console.WriteLine();
        roman1.AfficherDetails();
        Console.WriteLine();
        roman2.AfficherDetails();
        Console.WriteLine();
        roman3.AfficherDetails();
        List<Livres> bibliotheque = new List<Livres>();
        // Ajout des instances de Revue et Roman dans la liste
        bibliotheque.Add(revue1);
        bibliotheque.Add(revue2);
        bibliotheque.Add(revue3);
        bibliotheque.Add(roman1);
        bibliotheque.Add(roman2);
        bibliotheque.Add(roman3);

        // Parcours et affichage des détails
        Console.WriteLine("\n--- Contenu de la bibliothèque ---");
        foreach (var livres in bibliotheque)
        {
            livre.AfficherDetails();
            Console.WriteLine();
        }
    }
}
    
