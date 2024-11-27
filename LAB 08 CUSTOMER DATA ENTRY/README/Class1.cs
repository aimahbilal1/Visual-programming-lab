using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09_activity_1
{
    internal class ClassValidation
    {
        public void CheckCustomerName(String CustomerName)
        {
            if(CustomerName.Length >10)
            {
                throw new Exception("Name should be within 10 characters.");
                
            }
            else
                if(CustomerName == "")
            {
                throw new Exception("Name is required");
            }
        }
    }
}
