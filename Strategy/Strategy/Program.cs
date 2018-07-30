using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy - Fretes!");

            Pedido pedido1 = new Pedido(new CalculadorDeFretePadrao());
            pedido1.CalcularFrete();

            Pedido pedido2 = new Pedido(new CalculadorDeFreteExpresso());
            pedido2.CalcularFrete();
        }
    }
}
