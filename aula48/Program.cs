using System;

namespace aula48
{

    //trabalhando com Recusividade


    class Fatorial{

    public int fatorial(int n){//construtor retornar "int"
        int res;
        if(n<=1){//caso o argumento de entrada for menor que 1, não da pra fazer fatorial.
            res=1;
        }else{
            res=n*fatorial(n-1);
        }
        return res;
    }


    }

    class Program
    {
        static void Main()
        {
            Fatorial fac=new Fatorial();

            
        
            Console.WriteLine("Digite o número que você quer saber o fatorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int res = fac.fatorial(n);
            Console.WriteLine("O Resultado do fatorial de {0} é: {1}",n,res);
        }
    }
}
