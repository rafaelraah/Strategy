using System.Diagnostics;

namespace Strategy
{
    public class CalculadorDeFreteExpresso : ICalculadorDeFrete
    {
        public decimal CalcularFretePara(Pedido pedido)
        {
            Debug.WriteLine("Calculo de frete expresso!");
            return 2 + 2; //Calculo do frete
        }
    }
}
