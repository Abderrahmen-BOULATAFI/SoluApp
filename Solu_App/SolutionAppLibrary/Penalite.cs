using System;

namespace SolutionAppLibrary
{
    public class Penalite
    {
        // Attributs
        private TypePenalite type;
        private TimeSpan heure;
        private Tuple<double, double> position;

        // Constructeur
        public Penalite(TypePenalite type, TimeSpan heure, Tuple<double, double> position)
        {
            this.type = type;
            this.heure = heure;
            this.position = position;
        }

        // Propriétés
        public TypePenalite Type
        {
            get { return type; }
            set { type = value; }
        }

        public TimeSpan Heure
        {
            get { return heure; }
            set { heure = value; }
        }

        public Tuple<double, double> Position
        {
            get { return position; }
            set { position = value; }
        }

        // Autres méthodes si nécessaire
    }
}
