using System.Diagnostics;

namespace Strategy
{
    public class CalculadorDeFretePadrao : ICalculadorDeFrete
    {
        public decimal CalcularFretePara(Pedido pedido)
        {
            Debug.WriteLine("Calculo de frete padrao!");
            return 1 + 1; //Calculo do frete
        }
    }
}
