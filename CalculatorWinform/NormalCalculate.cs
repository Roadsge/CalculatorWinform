using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinform
{
    public class NormalCalculate
    {
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public decimal Plus(decimal one, decimal two) => one + two;
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public decimal Subtraction(decimal one, decimal two) => one - two;
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public decimal Devision(decimal one, decimal two) => one / two;
        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public decimal Multiplication(decimal one, decimal two) => one * two;
    }
}
