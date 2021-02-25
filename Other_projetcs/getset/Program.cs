using System;

namespace getset
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            //instaciado objeto da classe pessoa 


           p1.Nome = "Lukinhas";

            Console.WriteLine(p1.Nome);
        }
    }
}
