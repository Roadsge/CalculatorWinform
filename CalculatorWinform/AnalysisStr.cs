using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinform
{
    public class AnalysisStr
    {
        public string Analysis(string str)
        {
            if (str.Contains("➗"))
            {
                return str;
            }

            return "";
        }
    }
}
