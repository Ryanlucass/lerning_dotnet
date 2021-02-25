using System;

namespace _03
{

    public class valores
    {
        public int numbers;
        public int total;
        public int media;
        

        //Definindo uma array com dez espaços de valores
       


        //Função que faz todo o calculo
        public void Calculo(){

            for(int i=0; i<10; i++){
                
                Console.WriteLine("Digite o valor {0} :",i+1);
            
                numbers = int.Parse(Console.ReadLine());

                total +=numbers;
            }
             
            media = total/10;

            Console.WriteLine("A média é: {0}", media);

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
