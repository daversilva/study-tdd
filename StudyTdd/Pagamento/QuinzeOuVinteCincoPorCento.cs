
namespace StudyTdd.Pagamento
{
    public class QuinzeOuVinteCincoPorCento : RegraCalculo
    {
        protected override int Limite()
        {
            return 2500;
        }

        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.75;
        }

        protected override double PorcentagemBase()
        {
            return 0.85;
        }
    }
}
