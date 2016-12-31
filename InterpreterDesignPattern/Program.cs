using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structural = InterpreterDesignPattern.StructuralCode;
//using Structural = InterpreterDesignPattern.RealWorldCode;
//using Structural = InterpreterDesignPattern.MyCode;

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

            Structural.Context context = new Structural.Context();

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
                exp.Interpreter(context);
            }

            // Wait for user
            Console.ReadLine();
            #endregion

            #region Real world code in C#
            #endregion

            #region My code in C#
            #endregion
        }
    }
}
