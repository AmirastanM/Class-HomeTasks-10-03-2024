using System.Runtime.Serialization;

[Serializable]
internal class FactorialException : Exception
{
    public FactorialException(string msj)
    {
    }

    public class FactorialCalculator
    {
        public int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new FactorialException("Minus not asuccessful.");
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}