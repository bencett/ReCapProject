using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult<T>:DataResult<T>
    {
        public SuccessResult(T data,string message):base(data,true,message)
        {

        }

        public SuccessResult(T data):base(data,true)
        {

        }

        public SuccessResult(string message):base(default,true,message)
        {

        }

        public SuccessResult():base(default,true)
        {

        }
    }
}
