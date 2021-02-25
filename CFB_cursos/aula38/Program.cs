using System;

namespace aula38
{
//Trabalhando com métodos virtuais 
//são métodos que possuem os mesmos nomes, porém em classes diferentes 
    class Base
    {
        public Base(){
            Console.WriteLine("Construtor da classe Base");
        }

        virtual public void info(){
            Console.WriteLine("Base");
        }

    }

    class Derivada1:Base{

        public Derivada1(){
            Console.WriteLine("Construtor da classe Derivada 1");
        }
        override public void info(){
            //quando houver override, ele existe na classe base e estás endo sobreescrito 
            Console.WriteLine("Derivada 01");
        }

    }
    
    class Derivada2:Derivada1{

        public Derivada2(){
            Console.WriteLine("Construtor da classe Derivada 2");
        }

        override public void info(){
            //quando houver override, ele existe na classe base e estás endo sobreescrito 
            Console.WriteLine("Derivada 02");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Base Ref;
        Derivada1 derivada1=new Derivada1();
        Derivada2 derivada2=new Derivada2();
           
        Ref=derivada1;
        Ref.info();
           
        }
    }



}
