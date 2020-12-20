using System;

namespace aula24
{
    class aula24
    {
        static void Main()
        {
            //chamando o método na função principal
            //quando chamar um método que possui argumento é necessário colocar o seu valor 
           
           /*
            Console.WriteLine("Chamando o método soma: ");
            somar(13,34);

            Console.WriteLine("Chamando o método de multiplicação aplicando valores do teclado");
            
            int v1,v2;

            v1=Convert.ToInt32 (Console.ReadLine());
            v2=Convert.ToInt32 (Console.ReadLine());
            
            multiplicar(v1,v2);

            */
            int v1,v2,r; 
            
            v1=Convert.ToInt32 (Console.ReadLine());
            v2=Convert.ToInt32 (Console.ReadLine());
            r=divisao(v1,v2);
            Console.WriteLine("A divisão de {0} e {1} é: {2}",v1,v2,r);  


        }

        static void boasvindas()
        {
        //estou iniciando meu outro método, ele não tem argumentos de entrada, e nem retorna nada
        //para ele ser executado, ele precisa ser chamado na função principal "main"

        Console.WriteLine("Seja bem-vindo");

        }
        //inicializando o método com parâmetros de entrada 
        static void somar(int n1, int n2)
        {
            int res=n1+n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}",n1,n2,res);
        }

        static void multiplicar(int n1, int n2)
        {
            int res=n1 * n2;
            Console.WriteLine("A multiplicação de {0} e {1} é: {2}",n1,n2,res);          
        }
        
        static int divisao(int n1, int n2)
        {
            // definindo métodos que retornam alguma coisa, tenho que defirnir o seu tipo
            int res=n1/n2;
            return res;

        }

    }
}
