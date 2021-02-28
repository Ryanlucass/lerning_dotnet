using System;

namespace _04
{
//Faça um programa que leia dois vetores de 10 elementos.
//Crie um vetore que seja apenas os números que estão em ambos os vetores.
//não deve conter números repetidos 
    class vetores
    {

        




    }


    class Program
    {
        static void Main(string[] args)
        {
            
            int[] n= new int[4];

            for(int i=0; i<n.Length; i++){
                
                Console.WriteLine("diga o valor da posição ");

                n[i]= int.Parse(Console.ReadLine());
            }

            for(int p=0; p<n.Length; p++){
            Console.WriteLine("A posição {0} é: {1}",p+1,n[p]);
            }

            
            

        }
    }
}
