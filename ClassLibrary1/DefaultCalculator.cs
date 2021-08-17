namespace ClassLibrary1
{
    public class DefaultCalculator : ICalculateTax
    {
        public decimal Calculate(object order)
        {
            return 123.45M;
        }
    }
}
