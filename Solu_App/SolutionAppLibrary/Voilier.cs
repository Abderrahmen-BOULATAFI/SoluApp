using System;
using System.Collections.Generic;

namespace SolutionAppLibrary
{
    public class Voilier
    {
        // Attributs
        private string code;
        private List<Personne> equipage;
        private List<Entreprise> sponsors;
        public List<Epreuve> EpreuvesEffectuees { get; } = new List<Epreuve>();

        // Propriétés
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public List<Personne> Equipage
        {
            get { return equipage; }
            set { equipage = value; }
        }

        public List<Entreprise> Sponsors
        {
            get { return sponsors; }
            set { sponsors = value; }
        }

        // Constructeur
        public Voilier(string code)
        {
            this.code = code;
            this.equipage = new List<Personne>();
            this.sponsors = new List<Entreprise>();
        }

        public void AjouterMembreEquipage(Personne membre)
        {
            equipage.Add(membre);
        }

        public void SupprimerMembreEquipage(Personne membre)
        {
            equipage.Remove(membre);
        }

        public void AjouterSponsor(Entreprise sponsor)
        {
            sponsors.Add(sponsor);
        }

        public void SupprimerSponsor(Entreprise sponsor)
        {
            sponsors.Remove(sponsor);
        }

        // Autres méthodes si nécessaire
    }

}