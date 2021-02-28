using System;

namespace _04
{
//Faça um programa que leia dois vetores de 10 elementos.
//Crie um vetor que seja apenas os números que estão em ambos os vetores.
//não deve conter números repetidos 
    class vetores
    {

    // Criando os dois vetores de 10 elementos.

        int[] VetorA = new int[3];
        int[] VetorB = new int[3];
        int[] VetorC = new int[6];


        public void Calculo(){

            for(int a=0; a<VetorA.Length; a++){
                
                Console.Write("diga o valor do Vetor A na posição {0}: ",a+1);
                VetorA[a]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------------------------");

            for(int b=0; b<VetorB.Length; b++){

                Console.Write("diga o valor do Vetor B na posição {0}:",b+1);
                VetorB[b]=int.Parse(Console.ReadLine());
            }
        
            Console.WriteLine("--------------------------");

            //Chamando os valores do VetorA
            for(int r=0; r<VetorA.Length; r++){

                Console.WriteLine("A posição {0} do VetorA é: {1}",r+1,VetorA[r]);
            }

            Console.WriteLine("--------------------------");
            //Chamando os valores do VetorB
            
            for(int t=0; t<VetorB.Length; t++){

                Console.WriteLine("A posição {0} do VetorB é: {1}",t+1,VetorA[t]);
            }


        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            vetores resultado = new vetores();

            resultado.Calculo();
        
        }
    }
}
