using NUnit.Framework;
using StudyTdd.Pagamento;

namespace StudyTddTest.Pagamento
{
    [TestFixture]
    public class TestCalculadoraDeSalarios
    {
        private CalculadoraDeSalarios _calcula;

        [SetUp]
        public void Inicializar()
        {
            this._calcula = new CalculadoraDeSalarios();
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            var desenvolvedor = new Funcionario("David Rodrigues", 1000.0, new Cargo(new DezOuVintePorCento()));

            var salario = _calcula.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1000.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            var desenvolvedor = new Funcionario("Rodrigues", 4000.0, new Cargo(new DezOuVintePorCento()));

            var salario = _calcula.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDbasComSalarioAbaixoDoLimite()
        {
            var dba = new Funcionario("Silva", 1500.0, new Cargo(new QuinzeOuVinteCincoPorCento()));

            var salario = _calcula.CalculaSalario(dba);

            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDbasComSalarioAcimaDoLimite()
        {
            var dba = new Funcionario("Silva", 3500.0, new Cargo(new QuinzeOuVinteCincoPorCento()));

            double salario = _calcula.CalculaSalario(dba);

            Assert.AreEqual(3500.0 * 0.75, salario, 0.00001);
        }
    }
}
