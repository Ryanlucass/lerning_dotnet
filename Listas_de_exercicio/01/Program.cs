using System;

namespace _01
{

    //Faça um programa que leia dez números e mostre o número maior e o número menor 
    public class numeros{

        public int numbers,maior,menor;
        int i;

        public void resultado(){
            
            Console.WriteLine("Digite um Número");
            numbers = int.Parse(Console.ReadLine());

            maior = numbers;
            menor = numbers;

            for( i=1; i<10; i++){
                Console.WriteLine("Digite o números {0}ª:",i+1);
                numbers = int.Parse(Console.ReadLine());

                if(numbers>maior){
                    numbers = maior;
                }
                else
                {
                    if(numbers<menor){
                    menor = numbers;
                    }
                }

            }
                    Console.WriteLine("O maior número é {0}",maior);
                    Console.WriteLine("O menor número é {0}",menor);

        }
    }
    class Program
    {
        static void Main()
        {
            numeros n1=new numeros();

            n1.resultado();
            
            
        }
    }
}
