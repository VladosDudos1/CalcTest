using System;

namespace Calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            string symbol = Console.ReadLine();
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (symbol == "+")
                Console.WriteLine(Plus(num1, num2));
            else if (symbol == "-")
                Console.WriteLine(Minus(num1, num2));
            else if (symbol == "*")
                Console.WriteLine(Umnoj(num1, num2));
            else if (symbol == "/")
                Console.WriteLine(Delit(num1, num2));

            else
                Console.WriteLine("Change « +, -, *, / » !!!");

            Console.ReadKey();
        }
        public static double Umnoj(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public static double Plus(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public static double Minus(double firstNum, double secondNum)
        {
            return (firstNum - secondNum);
        }
        public static double Delit(double firstNum, double secondNum)
        {
            if (secondNum == 0) throw new DivideByZeroException();

            return firstNum / secondNum;
        }
    }
}
