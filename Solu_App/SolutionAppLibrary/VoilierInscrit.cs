using System;
using System.Collections.Generic;

namespace SolutionAppLibrary
{
    public class VoilierInscrit : Voilier
    {
        // Attributs
        private Course course;

        // Constructeur
        public VoilierInscrit(string code, Course course) : base(code)
        {
            this.course = course;
        }

        // Propriétés
        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
    }
}