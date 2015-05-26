
namespace StudyTdd.Pagamento
{
    public class CalculadoraDeSalarios
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
        }
    }
}
