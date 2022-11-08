using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
   public static class Methods
    {
        public static string CalcAction;
        public static void Calc( string firstValue, string secondValue)
        {
            if (CheckValues(firstValue, secondValue))
            {
                switch (CalcAction)
                {
                    case "+":
                        Add(firstValue, secondValue);
                        break;
                    case "-":
                        Substract(firstValue, secondValue);
                        break;
                    case "*":
                        Multiply(firstValue, secondValue);
                        break;
                    default:
                        Divide(firstValue, secondValue);
                        break;
                }
            }
        }
        public static void Add(string firstValue,string secondValue)
        {
            Console.WriteLine($"{firstValue} + {secondValue} = {Convert.ToDouble(firstValue) + Convert.ToDouble(secondValue)}");
        }
        public static void Substract( string firstValue, string secondValue)
        {
            Console.WriteLine($"{firstValue} - {secondValue} = {Convert.ToDouble(firstValue) + Convert.ToDouble(secondValue)}");
        }
        public static void Multiply(string firstValue, string secondValue)
        {
            Console.WriteLine($"{firstValue} * {secondValue} = {Convert.ToDouble(firstValue) * Convert.ToDouble(secondValue)}");
        }
        public static void Divide(string firstValue, string secondValue)
        {
            Console.WriteLine($"{firstValue} /  {secondValue} = {Convert.ToDouble(firstValue) / Convert.ToDouble(secondValue)}");
        }
        public static bool CheckValues(string firstValue, string secondValue)
        {
            double x;
            double y;

            if(!(CalcAction == "+" || CalcAction == "-" || CalcAction == "*" || CalcAction == "/"))
            {
                throw new CustomException("Incorrect operation");
            }
            try
            {
                x = Convert.ToDouble(firstValue);   
            }
            catch
            {
                throw new CustomException("Incorrect first value");
            }
            try
            {
                y = Convert.ToDouble(secondValue);
            }
            catch
            {
                throw new CustomException("Incorrect second value");
            }

            if(x<0 & y < 0)
            {
                throw new ArgumentOutOfRangeException("Values arte less then 0 ( values < 0 )");

            }
            if(x == 0 || y == 0)
            {
                throw new ArgumentOutOfRangeException("First or second values equals 0 ( values = 0");
            }
            if(x == 0 & y == 0)
            {
                throw new ArithmeticException("First and second values = 0 (values = 0)");
            }
            return true;
        }
    }
    
}
