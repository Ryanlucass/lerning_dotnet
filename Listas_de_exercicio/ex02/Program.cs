using System;

namespace ex02
/*Crie uma classe Mamifero, que herda de Animal (criado como no item acima) e que possui o método Mamar(). Crie, ainda, as classes Morcego (que possui o método Voar()) e Baleia (que possui o método Nadar()), derivadas de Mamifero;*/
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
    class Mamifero :Animal{

        //método mamar 
        public void Mamar(){
        
            Console.WriteLine("{0} Está mamando", nome);
        }


    }

    class Morcego :Mamifero{
        
        private string Voar(){

            return "Está voando";
        }

    }

    class Baleia: Mamifero{

        public void Nadar(){

            Console.WriteLine("{0} Está nadando",nome);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Baleia baleia = new Baleia();

            baleia.TesteAnimal("Baleia");
            baleia.Mamar();
            baleia.Nadar();

        }
    }
}
