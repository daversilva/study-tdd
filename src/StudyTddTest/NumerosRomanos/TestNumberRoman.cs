using NUnit.Framework;
using StudyTdd.NumerosRomanos;

namespace StudyTddTest.NumerosRomanos
{
    [TestFixture]
    public class TestNumberRoman
    {
        private ConversoDeNumeroRomano romano;

        [SetUp]
        public void Inicializar()
        {
            this.romano = new ConversoDeNumeroRomano();
        }

        [Test]
        public void DeveEntenderOSimboloI()
        {
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComo_II()
        {
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimboloDoisADoisComo_XXII()
        {
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderNumeroComo_IX()
        {
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [Test]
        public void DeveEntenderNumerosComplexosComo_XXIV()
        {
            int numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }
    }
}
