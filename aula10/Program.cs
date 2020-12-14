using System;

namespace aula10
{
    class aula10
    {
     enum DiasSemanas{segunda,terça,quarta,quinta,sexta,sábado,domingo};
        static void Main()
        {

          DiasSemanas ds = (DiasSemanas)1;
        // posição zero da "lista"

        //pegando o índice do argumento colocado 
        int cont=(int)DiasSemanas.terça;


          Console.WriteLine("O dia da semana é " +(ds )+ " com a posição de número: "+(cont) );

        }
    }
}
