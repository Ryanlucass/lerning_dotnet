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

            //Acrescentando valores ao Vetor A 
            for(int i=0; i<VetorA.Length; i++){
                
                Console.Write("diga o valor do Vetor A na posição {0}: ",i+1);
                VetorA[i]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------------------------");

            //Acrescentando valores ao Vetor B 
            for(int i=0; i<VetorB.Length; i++){

                Console.Write("diga o valor do Vetor B na posição {0}:",i+1);
                VetorB[i]=int.Parse(Console.ReadLine());
            }
        
            Console.WriteLine("--------------------------");

            //Chamando os valores do VetorA
            for(int i=0; i<VetorA.Length; i++){

                Console.WriteLine("A posição {0} do VetorA é: {1}",i+1,VetorA[i]);
            }

            Console.WriteLine("--------------------------");
            //Chamando os valores do VetorB
            
            for(int i=0; i<VetorB.Length; i++){

                Console.WriteLine("A posição {0} do VetorB é: {1}",i+1,VetorA[i]);
            }


             if(VetorA == VetorB){

                 for(int i=0; i<6; i++){
                
                Console.WriteLine("Teste");
                
                }
             }
            
                
               

            // for(int i=0; i<VetorC.Length; i++){

            //     Console.WriteLine("A posição {0} do VetorB é: {1}",i+1,VetorC[i]);
            // }

   
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
