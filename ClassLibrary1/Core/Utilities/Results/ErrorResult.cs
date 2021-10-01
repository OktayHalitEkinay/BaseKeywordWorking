using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(message,false)
        {
        }
    }
}
