﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydra.Admin.Utility.Exceptions
{
    public class DefinedException: Exception
    {
        public DefinedException(string message)
            : base(message)
        {
        }
    }
}
