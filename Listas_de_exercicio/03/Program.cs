using System;

namespace _03
{
    //Faca um programa que leia 10 números inteiros e imprima a sua média 
    
    public class Operacao
    {
        public int numero;
        public int media;
        public int total;
        int[] num= new int [10];

        public void calculo(){
            
            for(int i=0; i<num.Length; i++){

            Console.WriteLine("Digite o {0}ª Numero: ",i+1);

            numero = int.Parse(Console.ReadLine());

            total += numero;

            }

            media = total/10;

            Console.WriteLine("A média é {}",media);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Operacao b1 = new Operacao();

            b1.calculo();

        }
    }
}
