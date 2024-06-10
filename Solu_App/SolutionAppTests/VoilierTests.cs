using NUnit.Framework;
using SolutionAppLibrary;
using System;

namespace SolutionAppTests
{
    [TestFixture]
    public class VoilierTests
    {
        [Test]
        public void AjouterMembreEquipage_AjouteMembre_EquipageContientMembre()
        {
            // Arrange
            Voilier voilier = new Voilier("VA102SETE");
            Personne membre = new Personne("Jean", "Dupont", "Skipper");
            /*Personne membre = null;
            Assert.Throws<ArgumentNullException>(() => voilier.AjouterMembreEquipage(membre));
*/
            // Act
            voilier.AjouterMembreEquipage(membre);

            // Assert
            Assert.Contains(membre, voilier.Equipage);
        }

        [Test]
        public void SupprimerMembreEquipage_SupprimeMembre_EquipageNeContientPasMembre()
        {
            // Arrange
            Voilier voilier = new Voilier("VA102SETE");
            Personne membre = new Personne("Jean", "Dupont", "Skipper");
            voilier.AjouterMembreEquipage(membre);

            // Act
            voilier.SupprimerMembreEquipage(membre);

            // Assert
            Assert.IsFalse(voilier.Equipage.Contains(membre));
        }
    }
}
