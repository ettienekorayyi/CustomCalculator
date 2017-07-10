using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CustomCalculator.ISP;

namespace CustomCalculator.Common
{
    public class Validator : ICheckInputLimitValidator
    {
        private int counter = 1;
        public bool CheckInputValidator(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsNumber(c))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The input value is not a number." + "\n" + "Please try again.", "User Input Error");
                }
            }
            return false;
        }

        public string CheckInputLimitValidator(string number, StringBuilder sb, bool isClicked, string mainInput)
        {
            string str = String.Empty;
            if (counter < 20)
            {
                if (isClicked == true)
                {
                    mainInput = sb.Clear().ToString();
                    counter = 0;
                }
                mainInput = sb.Append(number).ToString();
                counter++;
            }
            return mainInput;
        }

        
    }
}
