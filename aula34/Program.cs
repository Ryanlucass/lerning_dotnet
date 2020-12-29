using System;

namespace aula34 //trabalhando com herança
{
    class Veiculo //classe base
    {
        public int rodas;
        public int velMax;
        private bool ligado;
        public void ligar(){
            ligado=true;
        }
        public void desligar(){
            ligado=false;
        }

        public string getLigado()
        {
            if(ligado){
                return "sim";
            }else
            {
                return "não";
            }
            
        }

    }

    class Carro:Veiculo{ //Classe derivada
        public string nome;
        public string cor;

    
        public Carro(String nome,string cor)
        {
        //Não consigo usar o objeto ligado, já que ele é private. mesmo sendo herdado.
            desligar();
            rodas=4;
            velMax=120;
            this.nome=nome;
            this.cor=cor;
        }

    }
    class Program
    {
        static void Main()
        {
         Carro c1=new Carro("Chevete","Vermelho");

         Console.WriteLine("Cor:...............{0}",c1.cor);
         Console.WriteLine("Nome:..............{0}",c1.nome);
         Console.WriteLine("Tamanho Rodas:.....{0}",c1.rodas);
         Console.WriteLine("Vel.Maxima:........{0}",c1.velMax);
         Console.WriteLine("Ligado.............{0}",c1.getLigado());  
        }
    }





}
