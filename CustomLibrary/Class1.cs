using ClassLibrary1;

namespace CustomLibrary
{
    public class CanadaTaxCalculator : ICalculateTax
    {
        public decimal Calculate(object order)
        {
            return 987.654M;
        }
    }
}
