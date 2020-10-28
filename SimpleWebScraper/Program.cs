using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new PersonBuilder().Build();
            Person person1 = new PersonBuilder().WithAge(35).Build();


        }
    }
}
