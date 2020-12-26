using System;

namespace classes
{
    public class Jogador{
    //criando uma classe jogador.
      
      public  int energia;
//deixando o nosso objeto público "public"
       public bool vivo;

    public Jogador(){
        energia=100;
        vivo=true;
    }   

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
            Jogador j2=new Jogador();
            Jogador j3=new Jogador();
            Jogador j4=new Jogador();

            j1.energia=50;
            //altereando o valor do objeto por ele ser público

            Console.WriteLine("A situação do jogador 1 é: {0} com a energia de: {1}",j1.vivo,j1.energia);
            Console.WriteLine("A situação do jogador 2 é: {0} com a energia de: {1}",j2.vivo,j2.energia);
            Console.WriteLine("A situação do jogador 3 é: {0} com a energia de: {1}",j3.vivo,j3.energia);
            Console.WriteLine("A situação do jogador 4 é: {0} com a energia de: {1}",j4.vivo,j4.energia);
            //como a propriedade está public, ele irá mostrar, energia e vivo
        }
    }


}
