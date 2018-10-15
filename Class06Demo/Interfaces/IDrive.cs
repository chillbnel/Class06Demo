using System;
using System.Collections.Generic;
using System.Text;

namespace Class06Demo.Interfaces
{
    //these are the requirements that the class must meet IOT use the interface
    interface IDrive
    {
       string DriversLicense { get; set; }

        void InsuranceCompany();
    }
}
