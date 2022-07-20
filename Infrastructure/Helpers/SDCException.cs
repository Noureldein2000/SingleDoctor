using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers
{
    public class SDCException : Exception
    {
        public string ErrorCode { get; private set; }
        public object ExceptionDate { get; set; }
        public SDCException() : base()
        {

        }

        public SDCException(string message, string errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
