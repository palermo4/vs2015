using static System.String;
using static System.Linq.Enumerable;

namespace Starter7.Models
{
    public class Person6
    {
        // auto property initializer
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        // read-only property with expression body
        public string FullName => $"{FirstName} {LastName}";
        // method with expression body
        public string GetLastNameFirst() => $"{LastName.ToUpper()}, {FirstName}";
        // method using static and more string interpolation
        public string GetTestData(string testName)
        {
            var dashLength = 25 - testName.Length;
            var dashes = Concat(Repeat("-", dashLength));
            return $"{{{testName}}} {dashes} {FullName}";
        }
    }
}
