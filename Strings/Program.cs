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
            var TestString = "  hjkhjkfhsd     ";
            Console.WriteLine(TestString);
            Console.WriteLine(TestString.Trim());
            Console.WriteLine(TestString.TrimEnd());
            Console.WriteLine(TestString.TrimStart());


            var Password = "P@ssw0rd";
            var Tekst = "abcdef";
            Console.WriteLine(Tekst.ToUpper());
            Console.WriteLine(Tekst.Substring(3));
            Console.WriteLine(Tekst.Substring(0, 2));
            Console.WriteLine(Tekst.Length);


            //var Uitdaging = “  Je kan c# voor tekstmanipulatie gebruiken en dat is geweldig!   “;
            //Twee voorloop spaties
            //Drie naloop spaties op het einde
            //Alle tekst Uppercase vanaf positie 52 tot 1 teken voor het einde.
            //Maak gebruik van Length

            var Uitdaging = "  Je kan c# voor tekstmanipulatie gebruiken en dat is geweldig!   ";
        





























        //Console.WriteLine(Uitdaging.Trim().Substring(52,Uitdaging.Trim().Length-53).ToUpper().Trim());
        Console.ReadLine();

        }
}
