using SEM2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEM2.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAll();
    }
}
