using System;

namespace SolutionAppLibrary
{
    public class Entreprise
    {
        // Attributs
        private string nom;
        private string adresse;
        private string contact;

        // Propriétés
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        // Constructeur
        public Entreprise(string nom, string adresse, string contact)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.contact = contact;
        }

        // Autres méthodes si nécessaire
    }
}
