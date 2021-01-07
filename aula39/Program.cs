using System;
//trabalhando com classes abstratas 
namespace aula39
{
    
    abstract class Veiculo
    {
        protected bool ligado;
        protected int veLmax;
        protected int velAtual;

      public Veiculo()
      {
        //normalmente usa o construtor para colocar os valores nos atributos 
        ligado=true;
        velAtual=0;
      }
      public void setLigado(bool ligado)
      {
        this.ligado=ligado;
      }

      public int getVelAtual(){
          return velAtual;
      }

      abstract public void aceleration(int velocidade);
      //ele não pode sequer ter as chavess
    }
    class Carro:Veiculo
    {
       public Carro(){
           veLmax=120;
       }
        override public void aceleration(int velocidade){
            //estou reescrevendo a função 
            velAtual+=10*velocidade;
      }



    }
    
    
    class Program
    {
        static void Main()
        {
            Carro car01=new Carro();

            car01.aceleration(13);
            // car01.aceleration(-1);
            Console.WriteLine("O valor atual da velocidade é {0}",car01.getVelAtual());
        }
    }




}
