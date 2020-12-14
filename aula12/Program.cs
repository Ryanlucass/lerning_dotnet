using System;

namespace aula12
{
    class condicionais
    {
        static void Main()
        {
            float nota;


          Console.WriteLine("Digite a nota do primeiro bimestre");
          nota=float.Parse(Console.ReadLine());

          if(nota >= 6.0){
              Console.WriteLine("Parabéns, você foi aprovado!");
          }
          else{
              Console.WriteLine("você foi reprovado");
          }

        }
    }
}
