using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Classes
{
    class Clown : Person, IDrive //class inherentence first, then interaces to implement afterward... you can have multiple interfaces
    {
        public bool IsScary { get; set; } = false;
        public string DriversLicense { get; set; }

        // access modifier can be used here in the class
        public void InsuranceCompany()
        {
            Console.WriteLine("My car is safe");
        }



    }
}
