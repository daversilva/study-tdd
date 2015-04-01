namespace StudyTdd.Pagamento
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public double Salario { get; set; }

        public Cargo Cargo { get; set; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }

    }
}
