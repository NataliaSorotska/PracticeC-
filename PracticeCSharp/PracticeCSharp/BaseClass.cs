using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class BaseClass
    {
        public String publicField = "BaseClass.PublicField";
        private String privateField = "BaseClass.PrivateField";
        protected String protectedField = "BaseClass.ProtectedField";

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
