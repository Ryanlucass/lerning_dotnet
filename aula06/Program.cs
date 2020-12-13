using System;

namespace aula06
{
    class Program
    {
        static void Main()
        {
            double ValorCompra=3.50;
            double ValorVenda;
            double lucro=0.1;
            string Produto="Pastel";

            ValorVenda=ValorCompra+(ValorCompra*lucro);

            //{0.15} é o tamanho do espaçamento entre os textos

            Console.WriteLine("Produto...........:{0,15}",Produto);
            Console.WriteLine("Val.Compra........:{0,15:c}",ValorCompra); //:c significa o cifrão
            Console.WriteLine("Lucro.............:{0,15:p}",lucro); //:p significa porcentagem 
            Console.WriteLine("Val.Venda.........:{0,15:c}",ValorVenda);
        }
    }
}
