using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRent
{
    internal class Student
    {
        public String Name { get; set; }
        public String Email { get; set; }



        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }

    

  
}
