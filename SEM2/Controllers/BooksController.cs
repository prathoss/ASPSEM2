using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEM2.Repository;

namespace SEM2.Controllers
{
    public class BooksController : Controller
    {

        IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {
            var books = _bookRepository.GetAll();
            return View();
        }
    }
}