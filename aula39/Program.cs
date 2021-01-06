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




      
    }
    
    
    class Program
    {
        static void Main()
        {
            
        }
    }




}
