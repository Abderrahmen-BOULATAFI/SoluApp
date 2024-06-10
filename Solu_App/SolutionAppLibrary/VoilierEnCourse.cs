using System;
using System.Collections.Generic;

namespace SolutionAppLibrary
{
    public class VoilierEnCourse : VoilierInscrit
    {
        // Attributs
        private TimeSpan tempsBrut;
        private List<Penalite> penalites;

        // Constructeur
        public VoilierEnCourse(VoilierInscrit voilierInscrit) : base(voilierInscrit.Code, voilierInscrit.Course)
        {
            this.tempsBrut = TimeSpan.Zero;
            this.penalites = new List<Penalite>();
        }

        // Propriétés
        public TimeSpan TempsBrut
        {
            get { return tempsBrut; }
            set { tempsBrut = value; }
        }

        public List<Penalite> Penalites
        {
            get { return penalites; }
            set { penalites = value; }
        }

        // Méthode pour enregistrer le temps brut du voilier en course
        public void EnregistrerTempsBrut(TimeSpan temps)
        {
            tempsBrut = temps;
        }

        // Méthode pour ajouter une pénalité au voilier en course
        public void AjouterPenalite(Penalite penalite)
        {
            penalites.Add(penalite);
        }

        // Méthode pour calculer le temps réel du voilier en course
        public TimeSpan CalculerTempsReel()
        {
            // Calculer la durée totale des pénalités
            TimeSpan dureePenalites = TimeSpan.Zero;
            foreach (Penalite penalite in penalites)
            {
                dureePenalites += penalite.Type.Duree;
            }

            // Temps réel = temps brut - durée des pénalités
            TimeSpan tempsReel = tempsBrut - dureePenalites;
            return tempsReel;
        }
    }
}