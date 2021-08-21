using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point(); // this statement creates a new instance of the Point class and invokes its default constructor.  
            
            Point bottomRight = new Point(1366, 768); // declared bottomRight variable of type Point. 
            // initialized it to a new Point object by using the constructor with two arguments and supplied the values 1366 and 768.


        }   // we CAN build from here, because the compiler generates an automatic constructor for the Point class(but its hidden). 

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
