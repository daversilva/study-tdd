using NUnit.Framework;

namespace StudyTdd.Pagamento
{
    [TestFixture]
    public class TestCalculadoraDeSalarios
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalarios calcula = new CalculadoraDeSalarios();
            Funcionario desenvolvedor = new Funcionario("David Rodrigues", 1000.0, Cargo.Desenvolvedor);

            double salario = calcula.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1000.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalarios calcula = new CalculadoraDeSalarios();
            Funcionario desenvolvedor = new Funcionario("Rodrigues", 4000.0, Cargo.Desenvolvedor);

            double salario = calcula.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDbasComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalarios calcula = new CalculadoraDeSalarios();
            Funcionario dba = new Funcionario("Silva", 1500.0, Cargo.Dba);

            double salario = calcula.CalculaSalario(dba);

            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDbasComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalarios calcula = new CalculadoraDeSalarios();
            Funcionario dba = new Funcionario("Silva", 3500.0, Cargo.Dba);

            double salario = calcula.CalculaSalario(dba);

            Assert.AreEqual(3500.0 * 0.75, salario, 0.00001);
        }
    }
}
