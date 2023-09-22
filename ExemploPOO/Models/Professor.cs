namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá caro aluno, seu nome é {Nome} e tenho {Idade} anos e a seu salário é: {Salario}");
        }
    }
}