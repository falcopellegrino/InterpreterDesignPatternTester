using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.MyCode
{
    /// <summary>
    /// The 'TerminalExpression' class
    /// </summary>
    class SixExpression: DigitExpression
    {
        public override int Zero() { return -1; }
        public override int One() { return -1; }
        public override int Two() { return -1; }
        public override int Three() { return -1; }
        public override int Four() { return -1; }
        public override int Five() { return -1; }
        public override int Six() { return 6; }
        public override int Seven() { return -1; }
        public override int Eight() { return -1; }
        public override int Nine() { return -1; }
    }
}
