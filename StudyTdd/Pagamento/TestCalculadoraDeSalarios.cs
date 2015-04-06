using NUnit.Framework;

namespace StudyTdd.Pagamento
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
            Funcionario desenvolvedor = new Funcionario("David Rodrigues", 1000.0, new Cargo(new DezOuVintePorCento()));

            double salario = _calcula.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1000.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            Funcionario desenvolvedor = new Funcionario("Rodrigues", 4000.0, new Cargo(new DezOuVintePorCento()));

            double salario = _calcula.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDbasComSalarioAbaixoDoLimite()
        {
            Funcionario dba = new Funcionario("Silva", 1500.0, new Cargo(new QuinzeOuVinteCincoPorCento()));

            double salario = _calcula.CalculaSalario(dba);

            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDbasComSalarioAcimaDoLimite()
        {
            Funcionario dba = new Funcionario("Silva", 3500.0, new Cargo(new QuinzeOuVinteCincoPorCento()));

            double salario = _calcula.CalculaSalario(dba);

            Assert.AreEqual(3500.0 * 0.75, salario, 0.00001);
        }
    }
}
