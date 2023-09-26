using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.ExceptionHandling
{
    internal class NameNull
    {
        static void Main(string[] args)
        {
            try
            {
                string str = null;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("Name is required");

                }
                Console.WriteLine(str);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());

            }
            finally {
                Console.WriteLine("Inside the Finally block"); 
            }
        }
    }
}
