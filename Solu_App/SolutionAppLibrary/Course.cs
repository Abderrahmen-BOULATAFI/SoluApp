using System;
using System.Collections.Generic;
namespace SolutionAppLibrary;



public class Course
{
    // Attributs
    private int id;
    private string nom;
    private DateTime dateDebut;
    private List<Voilier> voiliers;
    private List<Epreuve> epreuves;

    // Propriétés
    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public DateTime DateDebut
    {
        get { return dateDebut; }
        set { dateDebut = value; }
    }

    // Constructeur
    public Course(int id, string nom, DateTime dateDebut)
    {
        this.id = id;
        this.nom = nom;
        this.dateDebut = dateDebut;
        this.voiliers = new List<Voilier>();
        this.epreuves = new List<Epreuve>();
    }

    // Méthodes
    public void AjouterVoilier(Voilier voilier)
    {
        voiliers.Add(voilier);
    }

    public void SupprimerVoilier(Voilier voilier)
    {
        voiliers.Remove(voilier);
    }

    public void AjouterEpreuve(Epreuve epreuve)
    {
        epreuves.Add(epreuve);
    }

    public void SupprimerEpreuve(Epreuve epreuve)
    {
        epreuves.Remove(epreuve);
    }

    public void AfficherListeVoilier()
    {
        Console.WriteLine("Liste des voiliers :");
        foreach (Voilier voilier in voiliers)
        {
            Console.WriteLine($"- {voilier.Code}");
        }
    }

    public void AfficherListeEpreuve()
    {
        Console.WriteLine("Liste des épreuves :");
        foreach (Epreuve epreuve in epreuves)
        {
            Console.WriteLine($"- {epreuve.Libelle}");
        }
    }

    public void AfficherListeVoilierSponsors(Entreprise sponsor)
    {
        Console.WriteLine($"Liste des voiliers sponsorisés par {sponsor.Nom} :");
        foreach (Voilier voilier in voiliers)
        {
            if (voilier.Sponsors.Contains(sponsor))
            {
                Console.WriteLine($"- {voilier.Code}");
            }
        }
    }

    public void AfficherClassement()
    {
        Console.WriteLine("Classement des voiliers :");
        foreach (Voilier voilier in voiliers)
        {
            bool toutesEpreuvesEffectuees = epreuves.TrueForAll(epreuve => voilier.EpreuvesEffectuees.Contains(epreuve));
            if (toutesEpreuvesEffectuees)
            {
                // Afficher le voilier et son classement
                Console.WriteLine($"- {voilier.Code} : classement calculé...");
            }
            else
            {
                Console.WriteLine($"- {voilier.Code} : disqualifié");
            }
        }
    }
}
