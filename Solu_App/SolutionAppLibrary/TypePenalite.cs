using System;
using System.Collections.Generic;

namespace SolutionAppLibrary
{
    public class TypePenalite
    {
        // Attributs
        private string code;
        private TimeSpan duree;
        private string description;

        // Liste des pénalités associées à ce type de pénalité
        private List<Penalite> penalites;

        // Constructeur
        public TypePenalite(string code, TimeSpan duree, string description)
        {
            this.code = code;
            this.duree = duree;
            this.description = description;
            this.penalites = new List<Penalite>();
        }

        // Propriétés
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public TimeSpan Duree
        {
            get { return duree; }
            set { duree = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // Méthode pour créer une pénalité avec ce type de pénalité
        public Penalite CreerPenalite(TimeSpan heure, Tuple<double, double> position)
        {
            Penalite penalite = new Penalite(this, heure, position);
            penalites.Add(penalite);
            return penalite;
        }

        // Méthode pour supprimer une pénalité associée à ce type de pénalité
        public void SupprimerPenalite(Penalite penalite)
        {
            penalites.Remove(penalite);
        }
    }
}
