#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y; // here we added two private fields, x and y AND we will modify the constructors of these fields. 
        public Point()   //  here we have the default constructor because we arent passing anything in it. 
                        //The program will build with this. You only need to write a default constructor IF you have overloaded the other constructor. 
        {
            Console.WriteLine("Default constructor called");
            this.x = -1;
            this.y = -1; 
        }
        
        // The following is a public constructor that accepts two int arguments called x and y, that called 
        //the Console.WriteLine method to display the values of these arguments to the console.
        public Point(int x, int y)
        {
            this.x = x;   // this keyword    means " the field in this object (Point). 
            this.y = y; // this keyword is telling the compiler which variables are parameters and whcih 
                        // variables are fields ! 

            // // just this code alone will not compile(before I added more in, because we havent passed x and y into the Constructor from any Object yet. 
            // IS THIS CORRECT  -> above statement   ???????????
            // rather, the call to the DEFAULT constructor in the doWork Method (Point object is inside this method), is now invalid bc 
            //there is no longer a default constructor since we just overloaded it with two integers. 
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;  // although x and y are private fields, different instances of the same class can access them. 
            int yDiff = this.y - other.y;    // this.y is a field  other.y is a field. But PRIVATE operates at the class level.  
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff)); // looks like we can use the Math class because
            return distance; 
        
        }                                                                   // it is in the System NameSpace.  

    }  
}
