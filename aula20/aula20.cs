using System;

namespace aula20
{
    class repeticao
    {
        static void Main()
        {
            Console.WriteLine("Trabalhando com estruturas de repetição while");

            int[] num=new int[10];

            int i=0;
            while(i<num.Length){
            //vai executar até que essa condição não seja mais verdadeira 
                num[i]=0;

                Console.WriteLine(num[i]);
                i++;
            }

        }
    }
}
//ultimas apli