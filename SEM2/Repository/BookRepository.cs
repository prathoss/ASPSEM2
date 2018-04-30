using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEM2.Models;

namespace SEM2.Repository
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAll()
        {
            return _context.Books.ToList<Book>();
        }

        AppDBContext _context;

        public BookRepository(AppDBContext context)
        {
            _context = context;
        }
    }
}
