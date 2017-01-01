using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.MyCode
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class ConvertDigitContext
    {
        public ConvertDigitContext(string s)
        {
            this.Input = s;
        }
        public string Input { get; set; }
        public string Output { get; set; }
    }
}
