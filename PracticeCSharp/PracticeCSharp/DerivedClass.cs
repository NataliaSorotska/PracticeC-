using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class DerivedClass : BaseClass
    {
        public int deriverField;

        public DerivedClass(int number1, int number2):base(number1)
        {

            deriverField = number2;
        }

    }

}


