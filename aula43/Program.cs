using System;

namespace aula43
{

    public interface Veiculo{
        string ligar();
        string desligar();
        void info();
    }

    public interface Combate{
        string disparar();
    }
    
    
        class Carro:Veiculo,Combate{

        public bool ligado;
        public int ammo;
        public Carro(){
            ammo=0;
            ligado=false;
        }

        public string ligar(){
            if(ligado == true){
            return "O carro está ligado";
            }else{
                return "deu erro";
            }
            
        }
        public string desligar(){
           if(ligado == false){
            return "O carro está desligado";
           }else{
               return"deu erro";
           }

        }
        public string disparar(){
            if(ammo >0){
            return "O carro tem munição";
            }else{
            return"O carro não tem munição suficiente";
            }  
        
        }
        public void info(){
            Console.WriteLine("A situação do carro é: {0}, {1}",ligar(),disparar());
        }
    }




        class Program
    {
        static void Main()
        {
            Carro c1=new Carro();

            c1.info();
        }
    }
}
