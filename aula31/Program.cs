using System;

namespace classe_static
{
    
   static public class Jogador
    {

        static public int energia;
        static public bool vivo;
        static public string nome;

        static public void iniciar (string n)
        {
            energia=100;
            vivo=true;
            nome=n;
        }
     

//outro método para imprimir os valores
        static public void info()
        {
            Console.WriteLine("Nome Jogador:.....{0}",nome);    
            Console.WriteLine("Energia Jogador:..{0}",energia); 
            Console.WriteLine("status Jogador:...{0}\n",vivo); 
         
        }
    }
    class Program
    {
        static void Main()
        {
            j1.info();
           
        }
    }
}