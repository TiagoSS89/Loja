namespace Loja.Domain
{
    public class Calculadora
    {
        public decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");

            return a / b;
        }
    }
}
