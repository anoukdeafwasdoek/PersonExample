using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// Class of the People
    /// </summary>
    public class Person
    {
        /// <summary>
        /// This is the first name of the person
        /// </summary>
        public String FirstName { get; set; }

        public String LastName { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Static functions that returns the best person in the world.
        /// </summary>
        /// <returns>Returns the best person.</returns>
        static public Person GetBestPerson()
        {
            return new Person("Willem", "van Oranje");
        }

        /// <summary>
        /// Gets the name of the person.
        /// </summary>
        /// <returns>name</returns>
        public String GetName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            return "Person '" + GetName() + "' ";
        }
    }
}
