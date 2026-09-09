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

            #region Question02
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            ////yes, because this class can access internal fields from inside the same project/assembly
            #endregion

            #region Question03
            //Book book = new Book();
            //book.Title = "Clean Code";
            //Console.WriteLine(book.Title);
            #endregion

            #region Question04
            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion
        }
    }
    #region GeneralClass
    public class Book
    {
        private string Password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre Genre;
    }
    #endregion

    #region GeneralEnum
    public enum Genre { Fiction, NonFiction, Science }
    #endregion
}
