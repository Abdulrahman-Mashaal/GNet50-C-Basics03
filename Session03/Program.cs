using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            ////-Q01. Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine("Original title: " + title);
            //Console.WriteLine("Uppercase title: " + upperTitle);
            #endregion
            #region Question 2
            ////-Q01. Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            string title1 = "Clean Code";
            string title2 = "Clean Code";
            // refers to the same string literal in memory due to string interning
            bool areSame = ReferenceEquals(title1, title2);
            Console.WriteLine("Do they point to the same object? " + areSame);
            #endregion
        }
    }
}
