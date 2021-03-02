using System;

namespace ex01
{
    class Animal
    {

        public string nome;

        public string Acordar(){

           return "Está acordado";
            
        }

        public string Comer(){

            return "Está comendo";
        }

        public string Dormir(){

            return "Está dormindo";

        }

        public void TesteAnimal(){
            Console.WriteLine("Fazendo o teste: {0}, {1}, {2}",Acordar(),Comer(),Dormir());
  
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
