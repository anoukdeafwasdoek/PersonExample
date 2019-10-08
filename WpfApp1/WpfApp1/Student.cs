using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Student : Person
    {
        public override string ToString()
        {
            return "Student '" + GetName() + "' ";
        }

        public Student(string firstName, string lastName) : base(firstName,lastName)
        {
        }
    }
}
