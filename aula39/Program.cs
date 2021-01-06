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
        veLmax=100;
      }
      public void setLigado(bool conectado)
      {
        conectado=ligado;
      }

      abstract public void setVelAtual(int velocidade)
      {

      }




    }
    class Carro:Veiculo
    {
       public Carro(){
           veLmax:120;

       }
        override public void setVelAtual(int velocidade){
            velAtual+=10*velocidade; 
      }



    }
    
    
    class Program
    {
        static void Main()
        {
            
        }
    }




}
