﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class InversaoSaldoException : ArgumentOutOfRangeException
    {
        public InversaoSaldoException(string message) : base(message) { }
    }
}
