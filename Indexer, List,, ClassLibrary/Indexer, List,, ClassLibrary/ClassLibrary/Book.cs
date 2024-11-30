using Hel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer__List___ClassLibrary.ClassLibrary
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }

        public Book(string name,string authorName,int pageCount,int rowNumber)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = Helper.CreateBookCode(name,rowNumber);
        }
    }
}
