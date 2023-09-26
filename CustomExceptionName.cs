using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.ExceptionHandling
{
    internal class CustomExceptionName
    {
        public class NameException : Exception
        {
                             
            public NameException(string error) : base(error)
            {

            }
        }
        public class Student
        {
            public Student(string Name)
            {
                string str = null;
                if (string.IsNullOrEmpty(str))
                {
                    throw new NameException("Name is required");
                }
            }
        }

    }
}

    

