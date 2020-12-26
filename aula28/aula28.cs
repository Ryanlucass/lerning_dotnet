using System;

namespace classes
{
    public class Jogador{
    //criando uma classe jogador.
      
      public  int energia=100;
//deixando o nosso objeto público "public"
       public bool vivo=true;

    }

    public class aula28
    {
        static void Main()
        {
            //isntânciando um objeto, criando um objeto da classe jogador o j1
            //Jogador é a nossa classe
            // Nome do meu objeto j1
            //operador new Jogador, istânciei um novo objeto da classe jogador
            Jogador j1=new Jogador();
        }
    }


}
