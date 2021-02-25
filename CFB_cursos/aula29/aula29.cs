using System;

namespace aula29
{
public class Jogador{
    //criando uma classe jogador.
    public  int energia;
    //deixando o nosso objeto público "public"
    public bool vivo;
    public string nome;

/*
// utilizando um método construtor 

inicializar um objeto instânciado da classe
o onjetivo dele é inicializar as propriedades 

//se eu tenho um método que tem o mesmo nome da classe, esse é o método constutor 
*/

        public Jogador(){
        energia=100;
        vivo=true;
        nome="Jogador";
        
        }

        public Jogador(string n, int e){

        energia=e;
        vivo=true;
        nome=n;
        }   

        public Jogador(string n, int e, bool v){

        energia=e;
        vivo=v;
        nome=n;
        } 

//método construtor
        public Jogador(string n){

        energia=100;
        vivo=true;
        nome=n;
        }   

        public void info(){
            Console.WriteLine("Nome Jogador:.....{0}", nome);
            Console.WriteLine("Energia Jogador:..{0}", energia);
            Console.WriteLine("Estado Jogador:...{0}\n", vivo);
        }  

    }

    public class aula28
    {
        static void Main()
        {
           
            Jogador j1=new Jogador();
            Jogador j2=new Jogador("Lucas",34);
            Jogador j3=new Jogador("Théo",55);
            Jogador j4=new Jogador("Théo",0,false);

            j1.info();
            j2.info();
            j3.info();
            j4.info();
            
           
           
        }
    }


}
