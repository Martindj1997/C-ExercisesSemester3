using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_LambdaSorting
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Grade1 { get;}
        public int Grade2 { get;}
        public double Average { get { return (Grade1 + Grade2) / 2.0; } }

        public Student(string firstName, string lastName, int grade1, int grade2)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade1 = grade1;
            Grade2 = grade2;
        }

        public override string ToString()
        {
            return $"{FirstName, -10} {LastName, -10} {Grade1} {Grade2} {Average:f2}";
        }

    }
}
