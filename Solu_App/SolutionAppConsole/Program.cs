using System;
using SolutionAppLibrary;

namespace SolutionAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'une nouvelle course
            Course course = new Course(1, "Course de printemps", new DateTime(2024, 5, 1));

            // Création de quelques voiliers
            VoilierInscrit voilier1 = new VoilierInscrit("VA102SETE", course);
            VoilierInscrit voilier2 = new VoilierInscrit("VB201MARSEILLE", course);

            // Ajout des voiliers à la course
            course.AjouterVoilier(voilier1);
            course.AjouterVoilier(voilier2);

            // Affichage de la liste des voiliers inscrits à la course
            Console.WriteLine("Liste des voiliers inscrits à la course :");
            course.AfficherListeVoilier();

            // Création de quelques épreuves
            Epreuve epreuve1 = new Epreuve(1, "Contournement de balise", 1);
            Epreuve epreuve2 = new Epreuve(2, "Course chronométrée", 2);

            // Création d'un VoilierEnCourse
            VoilierEnCourse voilierEnCourse = new VoilierEnCourse(voilier1);

            // Ajout des épreuves à la course
            course.AjouterEpreuve(epreuve1);
            course.AjouterEpreuve(epreuve2);

            // Affichage de la liste des épreuves de la course
            Console.WriteLine("\nListe des épreuves de la course :");
            course.AfficherListeEpreuve();

            // Ajout de membres d'équipage à un voilier
            Personne skipper = new Personne("Jean", "Dupont", "Skipper");
            Personne equipier = new Personne("Paul", "Martin", "Equipier");

            voilier1.AjouterMembreEquipage(skipper);
            voilier1.AjouterMembreEquipage(equipier);

            // Affichage de l'équipage d'un voilier
            Console.WriteLine($"\nEquipage du voilier {voilier1.Code} :");
            foreach (Personne personne in voilier1.Equipage)
            {
                Console.WriteLine($"- {personne.Nom} {personne.Prenom} ({personne.Role})");
            }

            // Ajout de pénalités
            TypePenalite typePenalite = new TypePenalite("B02014", TimeSpan.FromMinutes(5), "Non-respect d'une balise en milieu de parcours");
            Penalite penalite = typePenalite.CreerPenalite(TimeSpan.FromHours(1), new Tuple<double, double>(45.1234, 5.6789));

            // Ajout de la pénalité au voilier en cours
            voilierEnCourse.AjouterPenalite(penalite);

            // Enregistrement du temps brut du voilier en cours
            voilierEnCourse.EnregistrerTempsBrut(TimeSpan.FromHours(2));

            // Calcul du temps réel du voilier en cours
            TimeSpan tempsReel = voilierEnCourse.CalculerTempsReel();
            Console.WriteLine($"\nTemps réel du voilier {voilier1.Code} : {tempsReel}");

            // Affichage du classement des voiliers
        
            course.AfficherClassement();

            // Affichage de la liste des voiliers sponsorisés par une entreprise spécifique
            Entreprise sponsor = new Entreprise("NomEntreprise", "AdresseEntreprise", "ContactEntreprise");
            voilier1.AjouterSponsor(sponsor);
            course.AfficherListeVoilierSponsors(sponsor);

            
        }
    }
}