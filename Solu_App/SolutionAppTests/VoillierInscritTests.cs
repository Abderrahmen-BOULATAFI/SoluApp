using NUnit.Framework;
using SolutionAppLibrary;
using System;

namespace SolutionAppTests
{
    [TestFixture]
    public class VoilierInscritTests
    {
        private Course course;

        [SetUp]
        public void Setup()
        {
            // Créer une nouvelle course pour les tests
            course = new Course(1, "Course de printemps", new DateTime(2024, 5, 1));
        }

        [Test]
        public void Constructeur_AvecCodeEtCourse_AssigneCorrectementLesValeurs()
        {
            // Arrange
            string code = "VA102SETE";

            // Act
            VoilierInscrit voilierInscrit = new VoilierInscrit(code, course);

            // Assert
            Assert.AreEqual(code, voilierInscrit.Code);
            Assert.AreEqual(course, voilierInscrit.Course);
        }

        [Test]
        public void AjouterMembreEquipage_AjouteMembre_EquipageContientMembre()
        {
            // Arrange
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            Personne membre = new Personne("Jean", "Dupont", "Skipper");

            // Act
            voilierInscrit.AjouterMembreEquipage(membre);

            // Assert
            Assert.Contains(membre, voilierInscrit.Equipage);
        }

        [Test]
        public void SupprimerMembreEquipage_SupprimeMembre_EquipageNeContientPasMembre()
        {
            // Arrange
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            Personne membre = new Personne("Jean", "Dupont", "Skipper");
            voilierInscrit.AjouterMembreEquipage(membre);

            // Act
            voilierInscrit.SupprimerMembreEquipage(membre);

            // Assert
            Assert.IsFalse(voilierInscrit.Equipage.Contains(membre));
        }

        [Test]
        public void AjouterSponsor_AjouteSponsor_SponsorsContientSponsor()
        {
            // Arrange
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            Entreprise sponsor = new Entreprise("NomEntreprise", "AdresseEntreprise", "ContactEntreprise");

            // Act
            voilierInscrit.AjouterSponsor(sponsor);

            // Assert
            Assert.Contains(sponsor, voilierInscrit.Sponsors);
        }

        [Test]
        public void SupprimerSponsor_SupprimeSponsor_SponsorsNeContientPasSponsor()
        {
            // Arrange
            VoilierInscrit voilierInscrit = new VoilierInscrit("VA102SETE", course);
            Entreprise sponsor = new Entreprise("NomEntreprise", "AdresseEntreprise", "ContactEntreprise");
            voilierInscrit.AjouterSponsor(sponsor);

            // Act
            voilierInscrit.SupprimerSponsor(sponsor);

            // Assert
            Assert.IsFalse(voilierInscrit.Sponsors.Contains(sponsor));
        }
    }
}
