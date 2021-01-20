using System;

namespace aula45
{

    struct Robo{

        public string nome;
        public string armas;

        public string sistema_operacional;

    
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
            int[] numeros =new int [10];
        
            Robo[] maquinas = new Robo[5];
            //Apenas chamanado as funções 

            maquinas[0].nome="batatinha";
            maquinas[0].armas="pistola";
            maquinas[0].sistema_operacional="linux";

            maquinas[1].nome="torrone";
            maquinas[1].armas="canhão";
            maquinas[1].sistema_operacional="windows";
            


            r1.info();
            r2.info();
            r3.info();
        }
    }



}
