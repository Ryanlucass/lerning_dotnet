using System;

namespace aula46
{

    class Galinha{

        public string NomeGalinha;
        public int QuantidadeOvo;

        static public int Totaleggs;


        public Galinha(string NomeGalinha){//definindo os valores para os argumentos e objetos 
            this.NomeGalinha=NomeGalinha;
            QuantidadeOvo=0;
            Totaleggs=0;
        }

        //criando o método que vai retornar o objeto
        public Ovo botar(){// ele retorna um objeto ovo  
            QuantidadeOvo++;
            Totaleggs++;
            return new Ovo(QuantidadeOvo, NomeGalinha);
        }

        



    }

    class Ovo{
        
        private int numOvo;
        private string minhaGalinha;

        public Ovo(int numOvo, string minhaGalinha){//construtor 
        //toda vez que eu chamar ovo, ele vai dizer que está criado
            this.numOvo=numOvo;
            this.minhaGalinha=minhaGalinha;
            Console.WriteLine("Quantidade de ovos criados pela Galinha {0}: {1}",this.minhaGalinha, this.numOvo);
        }


    }
    
    
    
    class Program
    {
        static void Main()
        {
            Galinha g1=new Galinha("Benedita");
            Galinha g2=new Galinha("Corcelia");
            Galinha g3=new Galinha("Tramulha");

            g1.botar();
            g1.botar();
            g1.botar();

            g2.botar();
            g2.botar();

            g3.botar();

            Console.WriteLine("\nQuantidade total de ovos criados: {0}",Galinha.Totaleggs);
            
        
        }
    }


}
