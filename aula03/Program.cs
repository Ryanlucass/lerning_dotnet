using System;

namespace aula03
{
    class Aula03
    {
        static void Main()
        {
        // tipo/nome/valor
        // variável inteiro: 
         int num = 0; 
         //variável char, só pode armazenar um caractere 
         char letra = 'L';
          //variável float
         float valor = 3.5f;
         //variável string 
         string nome = "Lucas Alves";
         // quando eu uso o var, eu não específico o tipo, ele indentifica na hora de compilar
         var aux= nome;

         Console.WriteLine(aux);
           
        }
    }
}


// using System;

// namespace Aula03{
//     // criando a classe
//     public class Aula03{
//     // cruando a função da classe:
//         static void variaveis(){
//         // tipo/nome/valor
//         // variável inteiro: 
//         int num = 0; 
//         //variável char, só pode armazenar um caractere 
//         char letra = 'L';
//          //variável float
//         float valor = 3.5f;
//         //variável string 
//         string nome = "Lucas Alves";
//         // quando eu uso o var, eu não específico o tipo, ele indentifica na hora de compilar
//         var aux= nome;

//         Console.WriteLine(aux);
//         }
//     }
// }