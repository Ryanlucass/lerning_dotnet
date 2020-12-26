using System;

namespace aula27
{
    class Program
    {
        static void Main()
        {
         soma(1,3,4,5,6,4,3,2,5,6,3);
        }

//trabalhando com os argumentos params 
        static void soma(params int[]n)
        //O argumento params, me possibilitar colocar um array dentro do meu argumento da função 
        {
            int res=0;

            if(n.Length < 1){
                Console.WriteLine("Não existem valores a serem somados");
            }else if(n.Length <2){
                Console.WriteLine("Valores insuficientes para a soma: {0}",n[0]);
            }else{
                for(int i=0; i<n.Length; i++){
                    res+=n[i];
                }
                Console.WriteLine("A soma dos valores é: {0}",res);
            }

        }
    }
}
