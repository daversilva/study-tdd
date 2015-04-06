using System.Dynamic;

namespace StudyTdd.Pagamento
{
    public class Cargo
    {
        public Cargo Desenvolvedor
        {
            get { return new Cargo(new DezOuVintePorCento()); }
        }

        public Cargo Dba
        {
            get { return new Cargo(new QuinzeOuVinteCincoPorCento()); }
        }

        public Cargo Testador
        {
            get { return new Cargo(new QuinzeOuVinteCincoPorCento()); }
        }

        public RegraCalculo Regra { get; private set; }

        public Cargo(RegraCalculo regra)
        {
            this.Regra = regra;
        }
    }
}