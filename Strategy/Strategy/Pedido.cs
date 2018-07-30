namespace Strategy
{
    public class Pedido
    {
        private ICalculadorDeFrete _calculadorDeFrete;

        /*Também poderia ter um método para atribuir o calculador, ou até mesmo no próprio método de CalcularFrete*/
        public Pedido(ICalculadorDeFrete calculadorDeFrete)
        {
            this._calculadorDeFrete = calculadorDeFrete;
        }

        public decimal CalcularFrete()
        {
            return _calculadorDeFrete.CalcularFretePara(this);
        }
    }
}