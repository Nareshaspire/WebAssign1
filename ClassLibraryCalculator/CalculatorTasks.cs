namespace ClassLibraryCalculator
{
    public class CalculatorApi

    {
        public static double AdditionTask(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double SubtractionTask(double num1, double num2)                                                            
        {
            
            return num1 - num2;
        }
        public static double MultiplicationTask(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double DivisionTask(double num1, double num2)
        {
            
            double answer;

            if (num2 == 0)
            {
                answer = -1;
            }
            else
            {
                answer = num1 / num2;
            }
            return answer;
        }
    }
}
