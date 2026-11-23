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

            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);

            #endregion
            #region Question 6
            //-Q06. Build the same sentence as above, but using string interpolation ($"...").

            //string interpolatedSentence = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(interpolatedSentence);

            #endregion
            #region Question 7
            //-Q07. Build the same sentence again, but using string.Format().

            //string formattedSentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(formattedSentence);

            #endregion
            #region Question 8
            //-Q08. Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion
            #region Question 9
            //-Q09. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.

            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            #endregion
            #region Question 10
            //-Q10. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            #endregion
            #region Question 11
            //-Q11. Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).

            int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            #endregion
        }
    }
}
