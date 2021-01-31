using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim, om spaties voor of achteraan een string te verwijderen
            var testString = "  hjkhjkfhsd     ";
            Console.WriteLine(testString);
            Console.WriteLine(testString.Trim());
            Console.WriteLine(testString.TrimEnd());
            Console.WriteLine(testString.TrimStart());


            var password = "P@ssw0rd";


            Console.ReadLine();

        }
    }
}
