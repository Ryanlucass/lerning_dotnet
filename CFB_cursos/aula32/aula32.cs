using System;

//elemento this 

namespace aula32
{

    class Calculos
    {
        public int v1;
        public int v2;

        public Calculos(int v1,int v2)
        {
            //this é referência do objeto da função
            this.v1=v1;
            this.v2=v2;
        }


        public int Somar()
        {
            return v1+v2;
        }

    }
    
    
    class Program
    {
        static void Main()
        {
            Calculos c=new Calculos(10,2);

            //quando é retorno eu preciso definir uma variável com o valor
            //Console.WriteLine(c);
            
           Console.WriteLine(c.Somar());
            
        }
    }






}
