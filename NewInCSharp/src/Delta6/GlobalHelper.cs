using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static System.Console;
using static System.String;
using static System.Linq.Enumerable;

namespace Delta6
{
    public static class GlobalHelper
    {
        public static string Log(string info) => $"{DateTime.Now.ToString()} : {info}";

        public static void TestPerson()
        {
            var me = new Person() { FirstName = "Michael", LastName = "Palermo" };

        }
    }

    public class Person
    {
        // auto property initializer
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";

        // readonly property initialized with expression body
        // assigned to value returned from string interpolation 
        public string FullName => $"{FirstName} {LastName}";

        // method defined with expression body
        public string GetLastNameFirst() => $"{LastName.ToUpper()}, {FirstName}";

        public void Test(string testName)
        {
            
            var dash = "-";
            var dashLength = 30 - testName.Length;
            //Console.WriteLine($"{testName} {string.Concat(Enumerable.Repeat(dash, 30-testName.Length)}");
            var s1 = $"{testName} {Concat(Repeat(dash, dashLength))}";

                Console.WriteLine(FullName);
            Console.WriteLine(GetLastNameFirst());
        }

    }

    // test default
    var um = new Person();
    um.Test(nameof(um));

// test initialized
var me = new Person() { FirstName = "Michael", LastName = "Palermo" };
    me.Test(nameof(me));

// test changed
var ah = um;
    ah.FirstName = "Dan";
ah.LastName = "Whalin";
ah.Test(nameof(ah));





}
