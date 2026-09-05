using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Method Overloading occurs when multiple methods in the same class share the same name but have different parameters different in  type, number, or order
            // Method Overriding occurs when a subclass provides a specific implementation of a method that is already defined in its parent class


            // b)  What is the difference between Static Binding and Dynamic Binding? 
            // Static Binding occurs when the code to be executed is linked to the method call at compile time
            // Dynamic Binding occurs when the code to be executed is linked to the method call at runtime

            #endregion

            #region Question02

            //(a) The sealed keyword prevents other classes from inheriting or deriving from it



             // (c)
            // Sealed Class prevents other classes from inheriting from it entirely.
           // Sealed Method prevents a specific method from being overridden in child classes



           // (c) No, it cannot, The sealed modifier explicitly locks the method's implementation. 

            #endregion





        }
    }
}
