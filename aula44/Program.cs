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

    }    
        
    class Program
    {
        static void Main()
        {
    
            Robo r1;

            r1.nome  = "Treme-Treme";
            r1.armas = "Sabre de luz";
            r1.sistema_operacional = "IOS";

            Console.WriteLine("Nome........{0}",r1.nome);
            Console.WriteLine("Armas.......{0}",r1.armas);
            Console.WriteLine("S.O.........{0}",r1.sistema_operacional);
        }
    }



}
