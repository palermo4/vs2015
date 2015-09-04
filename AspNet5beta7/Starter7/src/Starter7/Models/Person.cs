using System.Linq;

namespace Starter7.Models
{
    public class Person
    {
        private string _FirstName = "John";
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        private string _LastName = "Doe";
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        public string GetLastNameFirst()
        {
            return string.Format("{0}, {1}", LastName.ToUpper(), FirstName);
        }
        public string GetTestData(string testName)
        {
            var dashLength = 25 - testName.Length;
            var dashes = string.Concat(Enumerable.Repeat("-", dashLength));
            return string.Format("{{{0}}} {1} {2}", testName, dashes, FullName);
        }
    }
}
