using System;

namespace aula27
{
    class Program
    {
        static void Main()
        {
         Console.WriteLine("Função Main");
        }

//trabalhando com os argumentos params 
        static void soma(int n1, int n2)
        {
            int res= n1+n2;
            Console.WriteLine("A soma de {0} com {1} é {2}",n1,n2,res);
        }
    }
}
