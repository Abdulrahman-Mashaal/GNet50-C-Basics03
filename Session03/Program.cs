using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Text;

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
            ////-Q02. Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            //string title1 = "Clean Code";
            //string title2 = "Clean Code";
            //// refers to the same string literal in memory due to string interning
            //bool areSame = ReferenceEquals(title1, title2);
            //Console.WriteLine("Do they point to the same object? " + areSame);
            #endregion
            #region Question 3
            ////-Q03. Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            //// Using StringBuilder to efficiently build a string
            //StringBuilder sb = new StringBuilder();
            //// Append "Book List" to the StringBuilder
            //sb.Append("Book List");
            //// Append " - Updated" to the same StringBuilder object
            //sb.Append(" - Updated");
            //// Print the final result
            //Console.WriteLine(sb.ToString());
            #endregion
            #region Question 4
            ////-Q04. Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb.ToString());
            #endregion
            #region Question 5
            //-Q05. Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.

            string title = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + title + ", Pages: " + pages;
            Console.WriteLine(sentence);

            #endregion
        }
    }
}
