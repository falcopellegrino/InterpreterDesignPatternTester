using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.StructuralCode
{
    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    class NonterminalExpression: AbstractExpression
    {
        public override void Interpreter(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpreter");
        }
    }
}
