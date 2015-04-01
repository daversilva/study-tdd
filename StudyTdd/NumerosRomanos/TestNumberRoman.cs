using NUnit.Framework;

namespace StudyTdd.NumerosRomanos
{
    [TestFixture]
    public class TestNumberRoman
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversoDeNumeroRomano romano = new ConversoDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            ConversoDeNumeroRomano romano = new ConversoDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComo_II()
        {
            ConversoDeNumeroRomano romano = new ConversoDeNumeroRomano();
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimboloDoisADoisComo_XXII()
        {
            ConversoDeNumeroRomano romano = new ConversoDeNumeroRomano();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderNumeroComo_IX()
        {
            ConversoDeNumeroRomano romano = new ConversoDeNumeroRomano();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [Test]
        public void DeveEntenderNumerosComplexosComo_XXIV()
        {
            ConversoDeNumeroRomano romano = new ConversoDeNumeroRomano();
            int numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }
    }
}
