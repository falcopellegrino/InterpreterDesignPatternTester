using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.MyCode
{
    /// <summary>
    /// The 'AbstractExpression' class
    /// </summary>
    abstract class DigitExpression
    {
        public string Interpret(ConvertDigitContext context)
        {
            try
            {
                if (Int32.Parse(context.Input) == Zero()) return "Zero";
                if (Int32.Parse(context.Input) == One()) return "One";
                if (Int32.Parse(context.Input) == Two()) return "Two";
                if (Int32.Parse(context.Input) == Three()) return "Three";
                if (Int32.Parse(context.Input) == Four()) return "Four";
                if (Int32.Parse(context.Input) == Five()) return "Five";
                if (Int32.Parse(context.Input) == Six()) return "Six";
                if (Int32.Parse(context.Input) == Seven()) return "Seven";
                if (Int32.Parse(context.Input) == Eight()) return "Eight";
                if (Int32.Parse(context.Input) == Nine()) return "Nine";
            }
            catch (Exception e)
            {
                return string.Format(" ...{0} not interpretable!", context.Input);
            }
            return "";
        }

        public abstract int Zero();
        public abstract int One();
        public abstract int Two();
        public abstract int Three();
        public abstract int Four();
        public abstract int Five();
        public abstract int Six();
        public abstract int Seven();
        public abstract int Eight();
        public abstract int Nine();
    }
}
