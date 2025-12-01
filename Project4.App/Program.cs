using System;

namespace Project4
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString() => $"{Nome}, {Idade} anos";
    }

    internal class NewBaseType
    {
        public static void Main(string[] args)
        {
            var pessoa = new Pessoa("João Silva", 28);
            Console.WriteLine(pessoa);
        }
    }

    
}

