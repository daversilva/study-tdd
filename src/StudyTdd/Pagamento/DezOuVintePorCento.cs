
namespace StudyTdd.Pagamento
{
    public class DezOuVintePorCento : RegraCalculo
    {
        protected override int Limite()
        {
            return 3000;
        }

        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.8;
        }

        protected override double PorcentagemBase()
        {
            return 0.9;
        }
    }
}
