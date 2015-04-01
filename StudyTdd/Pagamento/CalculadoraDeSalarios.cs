
namespace StudyTdd.Pagamento
{
    public class CalculadoraDeSalarios
    {

        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargo.Desenvolvedor))
            {
                if (funcionario.Salario > 3000.0)
                    return funcionario.Salario * 0.8;

                return funcionario.Salario * 0.9;
            }

            if (funcionario.Cargo.Equals(Cargo.Dba))
            {
                if (funcionario.Salario > 2500.0)
                    return funcionario.Salario * 0.75;

                return funcionario.Salario * 0.85;
            }

            return 0;
        }
    }
}
