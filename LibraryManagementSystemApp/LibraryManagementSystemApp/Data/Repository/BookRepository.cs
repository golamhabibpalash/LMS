using LibraryManagementSystemApp.Data.Interfaces;
using LibraryManagementSystemApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystemApp.Data.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context):base(context)
        {

        }
        public IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllWIthAuthor()
        {
            throw new NotImplementedException();
        }
    }
}
