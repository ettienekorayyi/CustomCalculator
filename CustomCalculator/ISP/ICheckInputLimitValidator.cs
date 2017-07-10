using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCalculator.Common
{
    public interface ICheckInputLimitValidator
    {
        string CheckInputLimitValidator(string number, StringBuilder sb, bool isClicked, string mainInput);
    }
}
