using System;

namespace aula46
{

    class Galinha{

        private string NomeGalinha;
        private int QuantidadeOvo;


        public Galinha(string NomeGalinha, int QuantidadeOvo){//definindo os valores para os argumentos e objetos 
            this.NomeGalinha=NomeGalinha;
            QuantidadeOvo=0;
        }

        //criando o método que vai retornar o objeto
        public Ovo botar(){// ele retorna um objeto ovo  
            
            return new Ovo();
        }



    }

    class Ovo{

        public Ovo(){//construtor 
        //toda vez que eu chamar ovo, ele vai dizer que está criado
            Console.WriteLine("Ovo criado");
        }


    }
    
    
    
    class Program
    {
        static void Main()
        {
            
        }
    }


}
