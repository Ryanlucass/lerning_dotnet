using System;

namespace aula03
{
  
    public class variaveis{

        public static void teste(){
        // // tipo/nome/valor
        // // variável inteiro: 
        //  int num = 0; 
        //  //variável char, só pode armazenar um caractere 
        //  char letra = 'L';
        //   //variável float
        //  float valor = 3.5f;
        //  //variável string 
        //  string nome = "Lucas Alves";
        //  // quando eu uso o var, eu não específico o tipo, ele indentifica na hora de compilar
        //  var aux= nome;
        int num1=5;

        int num2=5;

        Console.Write("O Resultado da multiplicação de " + num1 + "x" + num2 + " é igual a: " + num1*num2);


        }

    }
    public class Aula03
    {
        static void Main()
        {
            variaveis Variaveis = new variaveis();
            variaveis.teste();
        }
    }

}