using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.ExceptionHandling
{
    internal class CustomExceptions
    {
        public class AgeException : Exception
        {
            //constructor                     call parent class constructor
            public AgeException(string error) : base(error)
            {

            }
        }
        public class User
        {
            public User(int age)
            {
                if (age < 18)
                {
                    throw new AgeException("You can not vote");
                }
            }
        }

    }
}
