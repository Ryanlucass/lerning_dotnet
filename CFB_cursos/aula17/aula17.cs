using System;

namespace aula17
{
    class array
    {
        static void Main()
        {
            //declarando arreys
            //nesse modo eu terei que definir o tamanho do meu array
            string[] s=new string[3]{"cadeira","computadores","internet"};
            //aqui ele irá ter o tamanho que a quantidade tiver
            float[] numbers={33.0f,32.1f,4.3f};

            //declarando valores 

            Console.WriteLine(s[2]);
            Console.WriteLine(numbers[0]);
        }
    }
}
