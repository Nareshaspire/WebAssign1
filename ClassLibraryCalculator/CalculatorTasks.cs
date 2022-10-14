using System;

namespace ClassLibraryCalculator
{
    public class CalculatorTasks
    {
        public static double AdditionTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and return their sum
        {
            return number1 + number2;
        }
        public static double SubtractionTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type                                                                //and then subtract them and return the result
        {
            
            return number1 - number2;
        }
        public static double MultiplicationTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and return their product
        {
            return number1 * number2;
        }
        public static double DivisionTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and return their quotient  as a floating-point number
        {
            
            double answer = 0;

            if (number2 == 0)
            {
                answer = -1;
            }
            else
            {
                answer = number1 / number2;
            }
            return answer;
        }
    }
}
