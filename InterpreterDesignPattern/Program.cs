using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structural = InterpreterDesignPattern.StructuralCode;
using Real = InterpreterDesignPattern.RealWorldCode;
using My = InterpreterDesignPattern.MyCode;

namespace InterpreterDesignPattern
{
    // Interpreter

    // Definition
    // Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - AbstractExpression (Expression)
    //      --> declares an interface for executing an operation
    //  - TerminalExpression (ThousandExpression, HundredExpression, TenExpression, OneExpression)
    //      --> implements an Interpret operation associated with terminal symbols in the grammar.
    //      --> an instance is required for every terminal symbol in the sentence.
    //  - NonterminalExpression (not used)
    //      --> one such class is required for every rule R ::= R1R2...Rn in the grammar
    //      --> maintains instance variables of type AbstractExpression for each of the symbols R1 through Rn.
    //      --> implements an Interpret operation for nonterminal symbols in the grammar.
    //          Interpret typically calls itself recursively on the variables representing R1 through Rn.
    //  - Context (Context)
    //      --> contains information that is global to the interpreter
    //  - Client (InterpreterApp)
    //      --> builds (or is given) an abstract syntax tree representing a particular sentence in the language that the grammar defines.
    //          The abstract syntax tree is assembled from instances of the NonterminalExpression and TerminalExpression classes
    //      --> invokes the Interpret operation

    /// <summary>
    /// MainApp startup class for Structural 
    /// Interpreter Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Interpreter patterns, which using a defined grammer,
            // provides the interpreter that processes parsed statements. 

            Structural.Context structural_context = new Structural.Context();

            // Usually a tree
            ArrayList list = new ArrayList();

            // Populate 'abstract syntax tree'
            list.Add(new Structural.TerminalExpression());
            list.Add(new Structural.NonterminalExpression());
            list.Add(new Structural.TerminalExpression());
            list.Add(new Structural.TerminalExpression());

            // Interpret
            foreach (Structural.AbstractExpression exp in list)
            {
                exp.Interpreter(structural_context);
            }

            // Wait for user
            Console.ReadLine();
            #endregion

            #region Real world code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Interpreter pattern which is used to convert a Roman numeral to a decimal.

            string roman = "MCMXXVIII";
            Real.Context real_context = new Real.Context(roman);

            // Build the 'parse tree';
            List<Real.Expression> tree = new List<Real.Expression>();
            tree.Add(new Real.ThousandExpression());
            tree.Add(new Real.HundredExpression());
            tree.Add(new Real.TenExpression());
            tree.Add(new Real.OneExpression());

            // Interpret
            foreach (Real.Expression exp in tree)
            {
                exp.Interpret(real_context);
            }

            Console.WriteLine("{0} = {1}", roman, real_context.Output);

            //Wait for user
            Console.ReadLine();
            #endregion

            #region My code in C#
            string input = (string)Console.ReadKey().KeyChar.ToString();
            My.ConvertDigitContext c = new My.ConvertDigitContext(input);
            Console.WriteLine("");

            // Buil the 'parse tree'
            List<My.DigitExpression> l = new List<My.DigitExpression>();
            l.Add(new My.ZeroExpression());
            l.Add(new My.OneExpression());
            l.Add(new My.TwoExpression());
            l.Add(new My.ThreeExpression());
            l.Add(new My.FourExpression());
            l.Add(new My.FiveExpression());
            l.Add(new My.SixExpression());
            l.Add(new My.SevenExpression());
            l.Add(new My.EightExpression());
            l.Add(new My.NineExpression());

            // Interpret
            foreach (My.DigitExpression d in l)
            {
                string r = d.Interpret(c);
                if (r != "")
                {
                    Console.WriteLine(r);
                }
            }

            // Wait for user
            Console.ReadLine();
            #endregion
        }
    }
}



















