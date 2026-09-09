namespace CSharpAssignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Book book = new Book();
            //Console.WriteLine(book.Password);
            ////It gives an error 'Book.Password' is inaccessible due to its protection level
            ////Because we can't access private fields outside of the Book class
            #endregion

        }
    }
    #region GeneralClass
    public class Book
    {
        private string Password = "secret";
    }
    #endregion
}
