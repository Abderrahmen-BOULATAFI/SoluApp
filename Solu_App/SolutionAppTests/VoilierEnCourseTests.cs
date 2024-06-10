using NUnit.Framework;
using SolutionAppLibrary;
using System;

namespace SolutionAppTests
{
    [TestFixture]
    public class VoilierEnCourseTests
    {
        [Test]
        public void EnregistrerTempsBrut_EnregistreTemps_TempsBrutEstCorrect()
        {
            // Arrange
            Course course = new Course(1, "Course de printemps", new DateTime(2024, 5, 1));
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            VoilierEnCourse voilierEnCourse = new VoilierEnCourse(voilierInscrit);
            TimeSpan temps = TimeSpan.FromHours(2);

            // Act
            voilierEnCourse.EnregistrerTempsBrut(temps);

            // Assert
            Assert.AreEqual(temps, voilierEnCourse.TempsBrut);
        }

        [Test]
        public void AjouterPenalite_AjoutePenalite_PenalitesContientPenalite()
        {
            // Arrange
            Course course = new Course(1, "Course de printemps", new DateTime(2024, 5, 1));
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            VoilierEnCourse voilierEnCourse = new VoilierEnCourse(voilierInscrit);
            TypePenalite typePenalite = new TypePenalite("B02014", TimeSpan.FromMinutes(5), "Non-respect d'une balise en milieu de parcours");
            Penalite penalite = typePenalite.CreerPenalite(TimeSpan.FromHours(1), new Tuple<double, double>(45.1234, 5.6789));

            // Act
            voilierEnCourse.AjouterPenalite(penalite);

            // Assert
            Assert.Contains(penalite, voilierEnCourse.Penalites);
        }

        [Test]
        public void CalculerTempsReel_CalculeTemps_TempsReelEstCorrect()
        {
            // Arrange
            Course course = new Course(1, "Course de printemps", new DateTime(2024, 5, 1));
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            VoilierEnCourse voilierEnCourse = new VoilierEnCourse(voilierInscrit);
            voilierEnCourse.EnregistrerTempsBrut(TimeSpan.FromHours(2));
            TypePenalite typePenalite = new TypePenalite("B02014", TimeSpan.FromMinutes(5), "Non-respect d'une balise en milieu de parcours");
            Penalite penalite = typePenalite.CreerPenalite(TimeSpan.FromHours(1), new Tuple<double, double>(45.1234, 5.6789));
            voilierEnCourse.AjouterPenalite(penalite);

            // Act
            TimeSpan tempsReel = voilierEnCourse.CalculerTempsReel();

            // Assert
            Assert.AreEqual(TimeSpan.FromHours(1.95), tempsReel);
        }
    }
}
