using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Interfaces.Infrastructure;
using WebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;


namespace WebStore.Controllers
{
    [Route("books/[action]")]
    public class BooksController:Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
    }
}
