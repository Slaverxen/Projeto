using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero_Chamada = 0;
            String  Nome_Aluno = "Filipe Bastos";

            Numero_Chamada = 1;
            Console.WriteLine(Numero_Chamada);
            Console.WriteLine(Nome_Aluno);

            Console.WriteLine(args[0].ToString());
            Console.WriteLine(args[1].ToString());
            Console.WriteLine(args[2].ToString());
            Console.WriteLine(args[3].ToString());


            Console.WriteLine("Hello World!");
        }
    }
}
