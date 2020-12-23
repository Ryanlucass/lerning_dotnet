using System;

namespace aula24
{
    class aula24
    {
     // començando a trabalhar com funções
        static void boasvindas()
        {
        //estou iniciando meu outro método, ele não tem argumentos de entrada, e nem retorna nada
        //para ele ser executado, ele precisa ser chamado na função principal "main"
        Console.WriteLine("Seja bem-vindo");

        }


        static void somar(int n1, int n2)
        {
            //inicializando o método com parâmetros de entrada 
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
    //passagem por referência, passar uma variável para dentro de uma função
        static void dobrar(ref int valor)
        {
            valor*=2;
        }
    //Argumento Out
        static int divide(int dividendo, int divisor, out int resto)
        {
            //aqui dentro ele só esta colocando as operações, ele não está definindo nenhum valor para a função
            //ele irá fazer isso na função main.
            int quociente;
            quociente=dividendo/divisor;
            resto=dividendo%divisor;
            return quociente;
        }

    // Argumento params
        static void adicionar(int n1, int n2)
        {
            int res = n1+n2;
            Console.WriteLine("A soma é {0}",res);
        }


        static void Main()
        {
            //chamando o método na função principal
            //quando chamar um método que possui argumento é necessário colocar o seu valor 
           
/*  //començando a trabalhar com funções

            Console.WriteLine("Chamando o método soma: ");
            somar(13,34);

            Console.WriteLine("Chamando o método de multiplicação aplicando valores do teclado");
            
            int v1,v2;

            v1=Convert.ToInt32 (Console.ReadLine());
            v2=Convert.ToInt32 (Console.ReadLine());
            
            multiplicar(v1,v2);

*/
/*
            Console.WriteLine("Dividindo números");

            int v1,v2,r;

            Console.WriteLine("\ndigite o primeiro valor: ");
            v1=Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("digite o segundo valor: ");
            v2=Convert.ToInt32 (Console.ReadLine());
            
            r=divisao(v1,v2);
            Console.WriteLine("A divisão de {0} e {1} é: {2}",v1,v2,r);  
*/
    //passagem por referência, passar uma variável para dentro de uma função

            // passamos uma variável para dentro do método "dobrar"
            //passagem por referência
/*
            Console.WriteLine("Dobrando o número: ");
            int num=10;
            dobrar(ref num);
            Console.WriteLine(num);
*/
    //Argumento Out

/*
            int divid,divis,quoc,rest;
            divid=10;
            divis=5;
            quoc=divide(divid,divis,out rest);

            Console.WriteLine("{0}/{1}: quociente={2} e resto={3}",divid,divis,quoc,rest);
*/
        console.WriteLine("digite o primeiro número: ");
        adicionar(3,4);


        }
    }
}
