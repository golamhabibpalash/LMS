﻿using LibraryManagementSystemApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystemApp.Data.Interfaces
{
    interface IBookRepository: IRepository<Book>
    {
        IEnumerable<Book> GetAllWIthAuthor();
        IEnumerable<Book> FindWithAuthor(Func<Book, bool>predicate);
        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
