using System;

namespace lerning_dotnet
{
    class Program
    {
        static void Main()
        {
        string DataNascimento,Nome,CPF,CEP;

        
        Console.WriteLine("\nPor favor, preenche o formulário abaixo para cadastrar suas informações no sistema.\n");
        
        Console.WriteLine("\nDigite o seu nome: ");
        Nome=Console.ReadLine();

        Console.WriteLine("\nDigite aqui a sua data de nascimento(sem barras): ");
        DataNascimento=Console.ReadLine();

        Console.WriteLine("\nDigite o seu CPF : ");
        CPF=Console.ReadLine();

        Console.WriteLine("\nDigite o seu CEP: ");
        CEP=Console.ReadLine();

        Console.WriteLine("\nO seu formulário está completo, confirmando os dados inseridos: ");

        Console.WriteLine("Nome....................:"+Nome);
        Console.WriteLine("Data de Nascimento......:"+DataNascimento);
        Console.WriteLine("CPF.....................:"+CPF);
        Console.WriteLine("CEP.....................:"+CEP);

        }
    }
}
