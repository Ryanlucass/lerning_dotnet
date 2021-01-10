using System;

namespace rcn
{
//Crie 3 classes: Carro, Moto, Bicicleta
//defina (onde se aplique) os métodos: LigarMotor(), Emplacar(), Acelerar() e Frear().
//Crie uma lista com 10 veículos considerando todas as classes criadas anteriormente, percorra cada Veículo e execute //os métodos aplicaveis a cada um.

 

    class Veiculos{//Classe base 
    
        public string LigarMotor(){
          return "Motor ligado";
        }
        public string Emplacar(){
            return "Emplacado(a)";
        }
        public string Acelerar(){
            return "Acelerando";
        }
        public string Frear(){
           return "Está Freando";

        }

        public void TesteVeiculoMotor(){
            Console.WriteLine("Fazendo o teste: {0} , {1} , {2},  {3}",Emplacar(),LigarMotor(),Acelerar(),Frear());
        }

        public void TesteVeiculo(){
            Console.WriteLine("Fazendo o teste: {0} , {1} , {2}",Emplacar(),Acelerar(),Frear());
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

        

        Console.WriteLine("Caminhão:");
        caminhao.TesteVeiculoMotor();

        Console.WriteLine("----Caminhote----");
        caminhote.TesteVeiculoMotor();

        Console.WriteLine("----Ônibus----");
        onibus.TesteVeiculoMotor();

        Console.WriteLine("----Ciclomotor----");
        ciclomotor.TesteVeiculoMotor();

        Console.WriteLine("----Ciclomotor----");
        ciclomotor.TesteVeiculoMotor();
       
        Console.WriteLine("----moto----");
        moto.TesteVeiculoMotor();
       
        Console.WriteLine("----motoneta----");
        motoneta.TesteVeiculoMotor();

        Console.WriteLine("----bicicleta----");
        bicicleta.TesteVeiculo();
        
        Console.WriteLine("----Cargueira----");
        cargueira.TesteVeiculo();
        
        Console.WriteLine("----Skate----");
        skate.TesteVeiculo();


        }
    }


}
 //chaci="preto";
   //         placa="RIO2A18";