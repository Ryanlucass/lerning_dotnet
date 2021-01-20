using System;

namespace aula46
{

    class Galinha{

        private string NomeGalinha;
        private int QuantidadeOvo;


        public Galinha(string NomeGalinha){//definindo os valores para os argumentos e objetos 
            this.NomeGalinha=NomeGalinha;
            QuantidadeOvo=0;
        }

        //criando o método que vai retornar o objeto
        public Ovo botar(){// ele retorna um objeto ovo  
            QuantidadeOvo++;
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
            Console.WriteLine("Ovo criado");
        }


    }
    
    
    
    class Program
    {
        static void Main()
        {
            Galinha g1=new Galinha("Benedita");

            g1.botar();
        }
    }


}
