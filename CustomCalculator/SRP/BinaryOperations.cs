using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCalculator.OCP;
using CustomCalculator.Common;

namespace CustomCalculator.SRP
{
    public class BinaryOperations : AbstractMathematicalOperation
    {

        public override int Addition(int augend, int addend)
        {
            int sum = augend + addend;
            return sum;
        }
        public override int Subtraction(int minuend, int subtrahend)
        {
            int difference = minuend - subtrahend; 
            return difference;
        }
        public override int Multiplication(int multiplicand, int multiplier)
        {
            int product = multiplicand * multiplier; 
            return product;
        }
        public override int Division(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            return quotient;
        }

        

        public string OperatorReplacer(string str, string btnTrigger)
        {
            int strLen = str.Length - 1;
            string updateOperator = str.Substring(0, strLen);

            switch (btnTrigger)
            {
                case "BtnAdd":
                    return updateOperator + OperatorConstants.AddSymbol;
                case "BtnSubtract":
                    return updateOperator + OperatorConstants.SubtractSymbol;
                case "BtnMultply":
                    return updateOperator + OperatorConstants.MultiplySymbol;
                case "BtnDivide":
                    return updateOperator + OperatorConstants.DivideSymbol;
            }

            return "The operator replacement failed.";
        }

    }
}
