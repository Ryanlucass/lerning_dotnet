using System;

namespace aula41
{
    class Carro{
        //trabalhando com Acessors GET e SET

        private int Velmax;

        public int vm{
            get {return Velmax;}

                set{
                if(value < 0){//value: valor passado
                    Velmax=0;
                }
                else if (value > 300){
                    Velmax=300;
                }else{
                    Velmax=value;
                }
            }
        }
       

        public Carro(){//construtor 
            vm=120;
        }


    }


    class Program
    {
        static void Main()
        {
            Carro c1=new Carro();

            c1.vm=310;
            Console.WriteLine("Velocidade...{0}",c1.vm);
        }
    }

}
