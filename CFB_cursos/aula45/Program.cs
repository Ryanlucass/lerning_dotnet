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
            //Apenas chamanado as funções colocando a posição do array de valor 5 

            maquinas[0].nome="batatinha";
            maquinas[0].armas="pistola";
            maquinas[0].sistema_operacional="linux";

            maquinas[1].nome="torrone";
            maquinas[1].armas="canhão";
            maquinas[1].sistema_operacional="windows";

            maquinas[2].nome="bambilim";
            maquinas[2].armas="taco de golf";
            maquinas[2].sistema_operacional="MacOS";

            maquinas[3].nome="trava trava ";
            maquinas[3].armas="38";
            maquinas[3].sistema_operacional="Android";

            maquinas[4].nome="riquinho";
            maquinas[4].armas="katana";
            maquinas[4].sistema_operacional="IOS";
            
            //criando um ciclo for para chamar as informações.
            for( int i=0; i<maquinas.Length; i++){
                maquinas[i].info();
            }
        }
    }



}
