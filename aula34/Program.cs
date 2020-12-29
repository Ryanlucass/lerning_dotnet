using System;

namespace aula34 //trabalhando com herança
{
    class Veiculo //classe base
    {

        public int velMax;
        private bool ligado;
        public void ligar(){
            ligado=true;
        }
        public void desligar(){
            ligado=false;
        }

    }

    class Carro:Veiculo{
    
    public Carro()
    {
        
    }

    }
    class Program
    {
        static void Main()
        {
         Carro c1=new Carro();

         c1.ligado=true;
        }
    }





}
