using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Person
    {
        string _ssn = "SSN";
        string _passportData = "DATA";
        string _driversLicenseNumber = "More DATA";
        string _firstName = "Avetis";
        string _lastName = "Ghuk";

        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicenseNumber.Length > 0;
            }
        }

       
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted");
                    return;
                }
                _firstName = value;
            }
        }


        public string LastName { get; set; }
    }
}
