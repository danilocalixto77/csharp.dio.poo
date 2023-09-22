namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá caro aluno, seu nome é {Nome} e tenho {Idade} anos e a sua nota é: {Nota}");
        }

    }
}