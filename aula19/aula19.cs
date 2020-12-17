using System;

namespace aula19
{
    class repetição
    {
        static void Main()
        {
            int[] n={33,44,55,66,44};
 
            //ele conta o tamanho do meu array
           for(int s=0; s<n.Length; s++){
            //Console.WriteLine(n[s]);

            Console.WriteLine("O valor do número na posição {0}: {1}",s,n[s]);

           }
        }
    }
}
//a função Lenght ela 