using System;


// utilizando a classe static 

namespace classe_static
{
    
   static public class Jogador
    {
//tenho que definir static em todas as minhas variáveis 
        static public int energia;
        static public bool vivo;
        static public string nome;

//não posso ter construtores na classe estatic 
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

    class Inimigo
    {
        public bool alerta;
        public string nome;

        public Inimigo(string n){
            alerta=false;
            nome=n;
        }

        public void infoenemy(){
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("-------------");

        }
    }
    class Program
    {
        static void Main()
        //não posso instanciar um onjeto,eu chamo ele diretamente 
        {

            Inimigo i1=new Inimigo("doidoo");
            Inimigo i2=new Inimigo("doidim");
            Inimigo i3=new Inimigo("pernalonga");

            i1.infoenemy();
            i2.infoenemy();
            i3.infoenemy();
           
        }
    }
}