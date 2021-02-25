using System;

namespace aula36
{
    class Veiculo{//base
        public int VelaAtual;
        private int VelMax;
        protected bool ligado;
        //protected permite o acesso aos membros pela classe derivada
        //protecd as classes derivadas também herdam e podem ser ecessadas 
        //private as classes derivadas não podem ser acessadas 
        
        public Veiculo(int VelMax){//construtor 
        VelaAtual=0;
        this.VelMax=VelMax;
        ligado=false; 
        }

        public string getLigado(){
            return (ligado?"sim":"não");
        }

        public int getVelmax(){
            return VelMax;
        }

    } 

    class Carro:Veiculo{//Derivada de Veículo
        public string nome;

        public Carro(string nome, int vm):base(vm){
        //inicializando um construtor da classe que precisa de um parâmetro 
        this.nome=nome;
        ligado=true;
        }
    }  

    
    class Program
    {
        static void Main()
        {
            Carro carr_01=new Carro("Marquinhos",120);

            Console.WriteLine("Nome...........{0}",carr_01.nome);
            Console.WriteLine("Vel.Máxima.....{0}",carr_01.getVelmax());
            Console.WriteLine("Ligado.........{0}",carr_01.getLigado());
        }
    }
}
