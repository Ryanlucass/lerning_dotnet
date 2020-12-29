using System;

namespace aula33
{
    
    class Jogador
    {
        //elementos private não podem ser acessaods diretamente nem instânciados  
        //private só pode ser usado dentro da classe 
        private int energia;
        private string nome; 

        //criando o meu construtor 
        public Jogador (string nome)
        {
            this.nome=nome;
            energia=100;
        }
//criando um método que retorna a energia 
//como ele está dentro da classe, ele pode dizer que a função getEnergia retoarna a energia que tá privada.
//o objeto está private, mas a função não, por isso é possíve chamar

        public int getEnergia()
        {
            return energia;
        }
//criando um método que retorna o nome 
        public string getNome()
        {
            return nome;
        }

        public void setEnergia(int e)
        //Método para alterar o valor da energia 
        {
        if(e<0)//verificando se o valor é negativo
        { 
            //verificando se eu tirar o valor inserido a minha energia continua 0
            //valor mínimo da energia 0 e máximo 100
            //é +, pois eu sei que ele é negativo, então + com o - é menos
            if(energia+e>=0){
                energia+=e;
            //energia = energia + e
            //100 = 100 + (-e);
            }else
            {
                energia=0;
            }
        
            
        }else if(e>0)//verificando se o valor é positivo
        {
            //verifica se o valor inserirdo a minha energia continua continua sendo menor que 100
            if(energia+e<=100)
            {
                energia+=e;
            }else
            {
                energia=100;
            }
        }
        
        }


    }
    class Program
    {
        static void Main()
        {
            Jogador j1 =new Jogador("Bruno");
            
            j1.setEnergia(-20);
            j1.setEnergia(-20);


            Console.WriteLine("Nome.......:{0}",j1.getNome());
            Console.WriteLine("Energia....:{0}",j1.getEnergia());
    
        }   

    }

}
