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

        public IActionResult Books()
        {
            return View(_bookService.GetAll());
        }

        public IActionResult BookDetails(int id)
        {
            //Получаем  по Id
            var book = _bookService.GetById(id);

            //Если такого не существует
            if (book == null)
                return NotFound(); // возвращаем результат 404 Not Found

            //Иначе возвращаем 
            return View(book);
        }

        /// <summary>
        /// Добавление или редактирование 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        //[Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new BookViewModel());

            var model = _bookService.GetById(id.Value);
            if (model == null)
                return NotFound();// возвращаем результат 404 Not Found

            return View(model);
        }

        [HttpPost]
        //[Route("edit/{id?}")]
        public IActionResult Edit(BookViewModel model)
        {
            if (model.Id > 0) // если есть Id, то редактируем модель
            {
                var dbItem = _bookService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();// возвращаем результат 404 Not Found

                dbItem.Author = model.Author;
                dbItem.Name = model.Name;
                
            }
            else // иначе добавляем модель в список
            {
                _bookService.AddNew(model);
            }
            _bookService.Commit(); // станет актуальным позднее (когда добавим БД)

            return RedirectToAction(nameof(Books));
        }

        [HttpPost]
        //[Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                _bookService.Delete(id);

            }

            return RedirectToAction(nameof(Books));
            //return View(Employees());

        }
    }
}
