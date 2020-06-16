using System;

namespace coding_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador teste = new Jogador();
            teste.nome = "testado";
            teste.posicao = "atacante";
            teste.dataNascimento = DateTime.Parse("05/02/1985");

            Console.WriteLine(teste.dadosJogador());
            Console.WriteLine( teste.calculaIdade() );
            Console.WriteLine( teste.aposentar() );

            /*
            */
            
        }
    }
}
