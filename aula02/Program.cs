using System;
// usando a biblioteca padrão de entrada e saída

namespace aula02 
// local onde vão ser organizados
{
    class Program
    // classe princpipal do nosso arquivo, já que estamos utilizando POO
    {
        // metodo principal da nossa classe 
        static void Main(string[] args)
        {
            Console.WriteLine("testando os argumentos");
            if(args.GetLength(0)>0)
            {
            Console.Write(args.GetValue(0));
            }
        }
    }
}

// se eu colocar um argumento de entrada na hora de utilziar o programa, ele vai pegar a posição zero, e enviar para lá 