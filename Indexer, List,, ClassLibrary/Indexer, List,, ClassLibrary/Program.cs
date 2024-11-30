using Indexer__List___ClassLibrary.ClassLibrary;

namespace Indexer__List___ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Library library = new Library();
            Book book1 = new Book("Elince Qalasi", "Dedeqorqud", 400, 3);
            library.AddBook(book1);
            Book book2 = new Book("Koroglu", "Mirze Elekber Sabir", 230, 4);
            library.AddBook(book2);

            var findBookName = library.FindAllBooksByName("Koroglu");
            foreach ( var findBook in findBookName )
            {
                Console.WriteLine(findBook.AuthorName);
            }

            var findBookCode = library.FindBookByCode("4");
            foreach ( var findBook in findBookCode)
            {
                Console.WriteLine(findBook.Name);
            }

            //var removeByName = library.RemoveAllBooksByNme("Dedeqorqud");
            //foreach ( var removeBook in removeByName)
            //{
            //    Console.WriteLine(removeBook.Name);
            //}

            var pageCountRange = library.FindAllBooksByPageCountRange(300, 600);
            foreach ( var findBook in pageCountRange)
            {
                Console.WriteLine(findBook.Name);
            }

        }
    }
}
