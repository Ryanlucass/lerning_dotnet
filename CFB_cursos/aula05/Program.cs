using System;

namespace aula05
{
    class Program
    {
        static void Main()
        {
            // & = AND
            // | = OR

            bool a=(5>3)|(5<3);

            Console.WriteLine("O resultado é " + a);

            bool b=(5>3)&(5<3);

             Console.WriteLine("O resultado é " + b);
             Console.WriteLine();
        }
    }
}
