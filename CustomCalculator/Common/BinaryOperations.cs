using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCalculator.Common
{
    class BinaryOperations
    {
        private static int sum { get; set; }

        public static int Addition(int num1,int num2)
        {
            sum = num1 + num2;            
            return sum;
        }
        public static int Subtraction(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        public static int Multiplication(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
        public static int Division(int num1, int num2)
        {
            int sum = num1 / num2;
            return sum;
        }
    }
}
