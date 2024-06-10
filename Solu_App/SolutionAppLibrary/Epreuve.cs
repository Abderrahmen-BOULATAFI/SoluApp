using System;

namespace SolutionAppLibrary
{
    public class Epreuve
    {
        // Attributs
        private int id;
        private string libelle;
        private int type;

        // Propriétés
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        // Constructeur
        public Epreuve(int id, string libelle, int type)
        {
            this.id = id;
            this.libelle = libelle;
            this.type = type;
        }

        // Autres méthodes si nécessaire
    }
}
