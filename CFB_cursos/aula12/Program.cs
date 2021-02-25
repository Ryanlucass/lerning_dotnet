using System;

namespace aula12
{
    class condicionais
    {
        static void Main()
        {

            Inicio:
        
            float nota;
            char resposta;


          Console.WriteLine("Digite a nota do primeiro bimestre");
          nota=float.Parse(Console.ReadLine());

          if(nota >= 6.0){
              Console.WriteLine("Parabéns, você foi aprovado!");
          }
          else if(nota < 4){
              Console.WriteLine("Você precisará fazer a av3");
          }
          else{
              Console.WriteLine("você foi reprovado");

            Console.WriteLine("Você deseja escrever outra nota? s/n: ");
            resposta=char.Parse(Console.ReadLine());
            
            if(resposta == 's' || resposta== 'S'){
                //para usar o operador == é necessário que use aspas simples
                Console.Clear();
                goto Inicio;
            }
            else{
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }




          }

        }
    }
}
