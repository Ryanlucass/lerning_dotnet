using System;

namespace aula21
{
    class repeticao
    {
        static void Main()
        {
         //com o do while primeiro ele executa e depois ele testa 

         string nome="lucas";
         string nomeuser;
         int tentativas=0;

         do{
             Console.Clear();
             Console.WriteLine("Começo com a letra: l");
             Console.WriteLine("Digite o meu nome: ");
             nomeuser=Console.ReadLine();
             tentativas++;
             
            if(tentativas == 2){
            Console.WriteLine("Sou um nome popular de 2001");
            }

            }while(nome != nomeuser);
            
            Console.Clear();
            Console.WriteLine("Nome correto, tentativas{0}",tentativas);

        }
    }

}
