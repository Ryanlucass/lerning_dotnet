using System;

namespace aula35 //trabalhando com herança
{
    class Veiculo //classe base
    {
        private int rodas;
        public int velMax;
        private bool ligado;
        
        
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
            if(ligado){
                return "sim";
            }else
            {
                return "não";
            }
            
        }

        public int getRodas(){
            return rodas;
        }

    }

    class Carro:Veiculo{ //Classe derivada
        public string nome;
        public string cor;

    
        public Carro(String nome,string cor)
        {
        //Não consigo usar o objeto ligado, já que ele é private. mesmo sendo herdado.
        //para isso eu preciso fazer uma função public que retorne meu objeto 
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
         Console.WriteLine("Tamanho Rodas:.....{0}",c1.getRodas());
         Console.WriteLine("Vel.Maxima:........{0}",c1.velMax);
         Console.WriteLine("Ligado.............{0}",c1.getLigado());  
        }
    }

//happy new yer!!




}
