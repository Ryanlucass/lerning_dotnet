using System;

namespace _02
{

    public class valores
    {
        public int numbers;
        public int Total;

        //Definindo uma array com dez espaços de valores
        int[] num= new int [10];


        //Função que faz todo o calculo
        public void Calculo(){

            for(int i=0; i<num.Length; i++){
                
                Console.WriteLine("Digite o valor {0} :",i+1);
            
                numbers = int.Parse(Console.ReadLine());

                Total +=numbers;
            }
            
            Console.WriteLine("O total da soma é {0}",Total);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //instanciei um onjeto da classe valores;
            valores n1 = new valores();

            n1.Calculo();
        }
    }
}
