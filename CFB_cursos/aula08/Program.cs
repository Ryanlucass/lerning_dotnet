using System;

namespace aula08
{
    class Aula08
    {
        static void Main()
        {
        
        int number1,number2,soma;
        string nome;

        Console.WriteLine("Por favor, digite o seu nome: ");
        nome=Console.ReadLine();
        
        Console.WriteLine("Digite o primeiro valor: ");
        //todo valor digitado pelo usuário virá como string, porntanto é necessário transferir de string para o formato necessário.
        number1=int.Parse(Console.ReadLine());

         Console.WriteLine("Digite o segundo valor: ");
         number2=int.Parse(Console.ReadLine());

        soma=number1+number2;

        Console.WriteLine("{0} A soma de {1} mais {2} é igual a {3}",nome,number1,number2,soma);

        }
   
   
    }
}
