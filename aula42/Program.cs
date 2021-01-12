using System;

namespace aula42
{
    class Carro{
        //trabalhando com Acessors GET e SET

        private int[] Velmax=new int[5]{80,120,160,240,300};

        public int this[int i]{
            get{
                return Velmax[i];
            
            }set{
                if(value < 0){//value: valor passado
                    Velmax[i]=0;
                }else if (value > 300){
                    Velmax[i]=300;
                }else{
                    Velmax[i]=value;
                }
            }
        }
       
    /*
        public Carro(){//construtor 
        
        }

    */

    }


    class Program
    {
        static void Main()
        {
            Carro c1=new Carro();

            c1[4]=120;
            Console.WriteLine("Velocidade...{0}",c1[4]);
        }
    }

}
