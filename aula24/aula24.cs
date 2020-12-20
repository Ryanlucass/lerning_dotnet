using System;

namespace aula24
{
    class aula24
    {
        static void Main()
        {
            //chamando o método na função principal
            //quando chamar um método que possui argumento é necessário colocar o seu valor 
            somar(2342340,5234234);
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

    }
}
