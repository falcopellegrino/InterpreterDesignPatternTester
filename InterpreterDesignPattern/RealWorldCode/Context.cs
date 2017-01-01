﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.RealWorldCode
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context
    {
        private string _input;
        private int _output;

        // Constructor
        public Context(string input)
        {
            this._input = input;
        }

        // Gets or sets input
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        // Gets or sets input
        public int Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}
