using System;
using System.Collections.Generic;

namespace aula57
{
    class Program
    {
        static void Main()
        {
        
          List<string> carros=new List<string>();           //Nome "List"; Tipo da List; Nome da Lista.

           carros.Add("Golf"); 
           carros.Add("HB20"); 
           carros.Add("Toro"); 
           carros.Add("Camaro"); 

           foreach(string c in carros)
           {
               Console.WriteLine(c);
           }

        }
    }
}
