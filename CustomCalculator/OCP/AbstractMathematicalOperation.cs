using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCalculator.OCP
{
    /// <summary>
    /// Represents Open/Close Principle
    /// 1.Replaced the abstract class name from AbstractMathematicalOperation 
    ///   to AbstractBinaryOperation because if I add the abstract properties
    ///   of UnaryOperation to this class it would be required to implement it
    ///   with the BinaryOperations since the UnaryOperation feature is not yet
    ///   created. 
    /// </summary>
    public abstract class AbstractMathematicalOperation
    {
        public abstract int Addition(int num1, int num2);
        public abstract int Subtraction(int num1, int num2);
        public abstract int Division(int num1, int num2);
        public abstract int Multiplication(int num1, int num2);
        //
        
    }
}
