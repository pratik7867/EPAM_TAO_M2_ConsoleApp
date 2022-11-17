using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_TAO_M2_ConsoleApp
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }
            else if (!(obj is Employee))
            {
                return false;
            }
            else
            {
                return (((Employee)obj).Id == this.Id && ((Employee)obj).Name == this.Name);
            }
        }        
    }
}
