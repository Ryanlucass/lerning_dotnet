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

        public void TesteAnimal(string nome){
            this.nome = nome;

            Console.WriteLine("Fazendo o teste do animal {0}: {1}, {2}, {3}",nome,Acordar(),Comer(),Dormir());
  
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            
           Animal camelo=new Animal();
           camelo.TesteAnimal("Onça");

           Animal Carneiro= new Animal();
           Carneiro.TesteAnimal("Carneiro");
        }
    }
}
