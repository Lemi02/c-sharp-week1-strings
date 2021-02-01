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
            var tekst = "abcdef";
            Console.WriteLine(tekst.ToUpper());
            Console.WriteLine(tekst.Substring(3));
            Console.WriteLine(tekst.Substring(0, 2));
            Console.WriteLine(tekst.Length);


            //var Uitdaging = “  Je kan c# voor tekstmanipulatie gebruiken en dat is geweldig!   “;
            //Twee voorloop spaties
            //Drie naloop spaties op het einde
            //Alle tekst Uppercase vanaf positie 52 tot 1 teken voor het einde.
            //Maak gebruik van Length

            var uitdaging = "  Je kan c# voor tekstmanipulatie gebruiken en dat is geweldig!   ";






























            //Console.WriteLine(Uitdaging.Trim().Substring(52,Uitdaging.Trim().Length-53).ToUpper().Trim());
            Console.ReadLine();

        }
    }
}
