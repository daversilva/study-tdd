
namespace StudyTdd.Pagamento
{
    public abstract class RegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario > Limite())
            {
                return funcionario.Salario * PorcentagemAcimaDoLimite();
            }
            return funcionario.Salario * PorcentagemBase();
        }

        protected abstract int Limite();

        protected abstract double PorcentagemAcimaDoLimite();

        protected abstract double PorcentagemBase();
    }
}