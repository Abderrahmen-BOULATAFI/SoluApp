using System;

namespace SolutionAppLibrary
{
    public class Personne
    {
        // Attributs
        private string nom;
        private string prenom;
        private string role;

        // Propriétés
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        // Constructeur
        public Personne(string nom, string prenom, string role)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.role = role;
        }

        // Autres méthodes si nécessaire
    }
}
