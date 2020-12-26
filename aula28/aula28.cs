using System;

namespace classes
{
public class Jogador{
    //criando uma classe jogador.
    public  int energia;
    //deixando o nosso objeto público "public"
    public bool vivo;

/*
// utilizando um método construtor 

inicializar um objeto instânciado da classe
o onjetivo dele é inicializar as propriedades 

//se eu tenho um método que tem o mesmo nome da classe, esse é o método constutor 
*/
    public string nome;

        public Jogador(string n){

        energia=100;
        vivo=true;
        nome=n;
        }   

        ~Jogador(){
            Console.WriteLine("Jogador {0} foi destruído", nome);
        }

    }

    public class aula28
    {
        static void Main()
        {
            // lendo o nome no teclado e adicionando a variável
            string nome;
            Console.WriteLine("Digite o nome do jogador 1: ");
            nome=Console.ReadLine();


            //isntânciando um objeto, criando um objeto da classe jogador o j1
            //Jogador é a nossa classe
            // Nome do meu objeto j1
            //operador new Jogador, istânciei um novo objeto da classe jogador
            Jogador j1=new Jogador(nome);
            Jogador j2=new Jogador("Lucas");
            Jogador j3=new Jogador("Mateus");
            Jogador j4=new Jogador("Rafael");

           
            //altereando o valor do objeto por ele ser público

            Console.WriteLine("A situação do jogador 1 é: {0} com a energia de: {1} e nome: {2}",j1.vivo,j1.energia,j1.nome);
            Console.WriteLine("A situação do jogador 2 é: {0} com a energia de: {1} e nome: {2}",j2.vivo,j2.energia,j2.nome);
            Console.WriteLine("A situação do jogador 3 é: {0} com a energia de: {1} e nome: {2}",j3.vivo,j3.energia,j3.nome);
            Console.WriteLine("A situação do jogador 4 é: {0} com a energia de: {1} e nome: {2}",j4.vivo,j4.energia,j4.nome);
            
            //como a propriedade está public, ele irá mostrar, energia e vivo
        }
    }


}
