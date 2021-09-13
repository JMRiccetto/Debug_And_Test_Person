using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void SinGuionNiPunto()
        {
            Person mary = new Person("Mary Jane", "53249395");
        }

        [Test]
        public void DigitosExtra()
        {
            Person romina = new Person("Romina Suárez", "5.324.93956-5");
        }

        [Test]
        public void Estandar()
        {
            Person dante = new Person("Dante Alighieri", "5.324.939-5");
        }
    }
}