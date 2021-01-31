using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepitions;

namespace Excepitions
{
    class connExcepitions : ApplicationException
    {
        public connExcepitions(string message) : base(message)
        {

        }
    }
}
