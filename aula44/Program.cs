using System;

namespace aula44
{

    struct Robo{

        public string nome;
        public string armas;

        public string sistema_operacional;

        public Robo(string nome, string armas, string sistema_operacional){
            this.armas=armas;
            this.sistema_operacional=sistema_operacional;
            this.nome=nome;
        }
        public void info(){
            //chamando uma método eclusivamente para guaradr as informações 
            Console.WriteLine("Nome........{0}",this.nome);
            Console.WriteLine("Armas.......{0}",this.armas);
            Console.WriteLine("S.O.........{0}",this.sistema_operacional);
            Console.WriteLine("--------------\n");
        }

    }

     
        
    class Program
    {
        static void Main()
        {
            //instânciando um novo objeto no construtor que recebe argumentos para cada robo 
            Robo r1=new Robo("Máquina de guerra","Metralhadora","Linux\n");
            Robo r2=new Robo("Ferreirinha","Taco de basebal","Windows\n");
            Robo r3=new Robo("Tuque tuque","Katana","MacOs\n");

            //Apenas chamanado as funções 
            r1.info();
            r2.info();
            r3.info();
        }
    }



}
