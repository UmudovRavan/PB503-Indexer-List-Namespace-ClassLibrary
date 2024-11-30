using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer__List___ClassLibrary.ClassLibrary
{
    public class Library
    {
        List<Book> books = new List<Book>();

       public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> allBookName = new List<Book>();

            foreach (var book in books)
            {
                if (book.Name.ToLower().Contains(value.ToLower()))
                {
                    allBookName.Add(book);
                }
            }
            return allBookName;
        }

        public List<Book> FindBookByCode(string code)
        {
            List<Book > findBookByCode = new List<Book>();

            foreach (var book in books)
            {
                if (book.Code.ToLower().Contains(code.ToLower()))
                {
                    findBookByCode.Add(book);
                }

            }
            return findBookByCode;
        }

            
        public void RemoveAllBooksByNme(string value)
        {
            List<Book> removeBook = new List<Book>();

            foreach (var book in books)
            {
                if (book.Name.ToLower().Contains(value.ToLower()))
                {
                    removeBook.Add(book);
                }
            }

            foreach (var book in removeBook)
            {
                books.Remove(book);
            }
        }

        public List<Book> SearchBooks(string value)
        {
            List <Book> searcedBook = new List<Book>();

            foreach(var book in books)
            {
                if (book.Name.ToLower().Contains(value.ToLower()) ||
                book.AuthorName.ToLower().Contains(value.ToLower()) ||
                book.PageCount.ToString().Contains(value.ToLower()))
                {
                    searcedBook.Add(book);
                }
            }
            return searcedBook;
        }

        public List<Book> FindAllBooksByPageCountRange(int maxPage, int minPage)
        {
            List<Book> findAllBook = new List<Book>();

            foreach (var book in books)
            {
                if(book.PageCount>= minPage &&  book.PageCount<= maxPage)
                {
                    findAllBook.Add(book);
                }
            }
            return findAllBook;
        }

        public void RemoveBookByCode(string code)
        {
            List<Book> removeCode = new List<Book>();

            foreach (var book in books)
            {
                if (book.Code.ToLower().Contains(code.ToLower()))
                 { 

                    removeCode.Add(book);
                }

            }
            foreach (var book in removeCode)
            {
                books.Remove(book);
            }
        }

    }
}
