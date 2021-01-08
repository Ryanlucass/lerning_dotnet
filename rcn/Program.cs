using System;

namespace rcn
{
//Crie 3 classes: Carro, Moto, Bicicleta
//defina (onde se aplique) os métodos: LigarMotor(), Emplacar(), Acelerar() e Frear().
//Crie uma lista com 10 veículos considerando todas as classes criadas anteriormente, percorra cada Veículo e execute //os métodos aplicaveis a cada um.

 

    class Veiculos{//Classe base 

//      public int veloMotor;

/*
        public Veiculos(int veloAtual){//criando construtor para definir valores 
            veloMotor=veloAtual;
        }

*/
        public bool ligado;
        public string emplacado;
        public bool acelerando;

        public bool frear;
        public void LigarMotor(){
            ligado=true;
        }
        public void Emplacar(){
            "O veículo está emplacado";
        }
        public void Acelerar(){
            acelerando=true;
        }
        public void Frear(){
            frear=true;

        }
    }

    class Carro:Veiculos{


    }
    class Moto:Veiculos{

    }
    class Bicicleta:Veiculos{

    }
    class Program
    {
        static void Main()
        {
        
        //Veículos pessados separei para uma maior compreensão 
        Veiculos caminhao=new Veiculos();
        Veiculos caminhote=new Veiculos();
        Veiculos onibus=new Veiculos();
        
        //Veículos com duas rodas, que possuem motor 
        Moto ciclomotor=new Moto();
        Moto moto=new Moto();
        Moto motoneta=new Moto();
        
        //Veículo "leve" de quatro rodas
        Carro carro=new Carro();
        
        //veículos que não possuem motor 
        Bicicleta bicicleta=new Bicicleta();
        Bicicleta cargueira=new Bicicleta();
        Bicicleta skate=new Bicicleta();

        

        Console.WriteLine("----Caminhão-----");

        caminhao.Emplacar();


        }
    }


}
 //chaci="preto";
   //         placa="RIO2A18";