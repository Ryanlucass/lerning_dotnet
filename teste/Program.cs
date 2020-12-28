using System;

namespace ldd
{
    class Program
    {
        static void Main()
        {
        string DataNascimento,Nome,CPF,CEP;

        
        Console.WriteLine("\nPor favor, preencha o formulário abaixo para cadastrar suas informações no sistema.\n");
        Console.WriteLine("\nColocar todas as pontuações necessárias\n");
        
        Console.WriteLine("\nDigite o seu nome: ");
        Nome=Console.ReadLine();

        Console.WriteLine("\nDigite aqui a sua data de nascimento: ");
        DataNascimento=Console.ReadLine();

        Console.WriteLine("\nDigite o seu CPF : ");
        CPF=Console.ReadLine();

        Console.WriteLine("\nDigite o seu CEP: ");
        CEP=Console.ReadLine();

        Console.WriteLine("\nO seu formulário está completo, confirmando os dados inseridos: ");

        Console.WriteLine("Nome....................: "+Nome);
        Console.WriteLine("Data de Nascimento......: "+DataNascimento);
        Console.WriteLine("CPF.....................: "+CPF);
        Console.WriteLine("CEP.....................: "+CEP);

        }
    }
}
