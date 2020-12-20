using System;

namespace aula22
{
    class repeticao
    {
        static void Main()
        {
            int[] num=new int [5]{11,22,33,44,55};
            //a estrutura do foreach 

            //ele serve para criar um contador, não tem a quantidade de opção igual ao for
            foreach(int n in num){
                Console.WriteLine(n);
            }
        }
    }
}
