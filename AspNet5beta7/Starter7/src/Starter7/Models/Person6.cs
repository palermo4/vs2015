using static System.String;
using static System.Linq.Enumerable;

namespace Starter7.Models
{
    public class Person6
    {
        // auto property initializer
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";
        public string FullName => $"{FirstName} {LastName}";
        public string GetLastNameFirst() => $"{LastName.ToUpper()}, {FirstName}";
        public string GetTestData(string testName)
        {
            var dashLength = 25 - testName.Length;
            var dashes = Concat(Repeat("-", dashLength));
            return $"{{{testName}}} {dashes} {FullName}";
        }
    }
}
