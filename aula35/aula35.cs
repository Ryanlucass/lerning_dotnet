using System;

namespace aula35 //trabalhando com herança
{
    
    class Veiculo //classe base
    {
        private int rodas;

        public int velMax;
        private bool ligado;
        
        //construtor 
        public Veiculo(int rodas)
        {
            this.rodas=rodas;
        }
        
        public void ligar(){
            ligado=true;
        }
        public void desligar(){
            ligado=false;
        }

        public string getLigado()
        {
            //utilizando opearadores ternários
            return (ligado?"sim":"não");
        }

        public int getRodas(){
            return rodas;
        }

        public void setRodas(int rodas){
            if(rodas<0){
                this.rodas=0;
            } else if(rodas>10){
                this.rodas=10;
            }else{
                this.rodas=rodas;
            }
        }

    }

    class Carro:Veiculo{ //Classe derivada
        public string nome;
        public string cor;

    
        public Carro(String nome, string cor):base(4)
        {
        //QUANDO VOCÊ HERDA UMA CLASSE, VOCÊ PRECISA OBSERVAR OS CONTRUTORES, SE ELES PRECISAREM DE PARAMETROS
        //VOCÊ DEVE USAR O ":BASE("valor do construtor")", isso serve para classe que está herdando 
        //Não consigo usar o objeto ligado, já que ele é private. mesmo sendo herdado.
        //para isso eu preciso fazer uma função public que retorne meu objeto 
            desligar();
            velMax=120;
            this.nome=nome;
            this.cor=cor;
        }

    }

    class CarroCombate:Carro{
        
        public int ammo;

        public CarroCombate():base("battle Car","Red"){
        //no construtor estou definindo os argumentos da classe herdada 
            ammo=100;
            setRodas(6);
        }

        
    }

    class Program
    {
        static void Main()
        {
        Carro c1=new Carro("Chevete","Vermelho");
        CarroCombate cc1=new CarroCombate();
         
        c1.ligar();

        Console.WriteLine("Características do Carro: ");

        Console.WriteLine("Cor:...............{0}",c1.cor);
        Console.WriteLine("Nome:..............{0}",c1.nome);
        Console.WriteLine("Tamanho Rodas:.....{0}",c1.getRodas());
        Console.WriteLine("Vel.Maxima:........{0}",c1.velMax);
        Console.WriteLine("Ligado.............{0}",c1.getLigado());  

        Console.WriteLine("---------------------");

        Console.WriteLine("Características do Carro de combate: ");
        
        Console.WriteLine("Cor:...............{0}",cc1.cor);
        Console.WriteLine("Nome:..............{0}",cc1.nome);
        Console.WriteLine("Tamanho Rodas:.....{0}",cc1.getRodas());
        Console.WriteLine("Vel.Maxima:........{0}",c1.velMax);
        Console.WriteLine("Ligado.............{0}",c1.getLigado());
        Console.WriteLine("Ammo...............{0}",cc1.ammo);  
         
        }
    }






}
