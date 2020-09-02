using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryBookService:IBookService
    {
        private readonly List<BookViewModel> _books = new List<BookViewModel>
        {
            new BookViewModel
            {
                Id = 1,
                Author = "Pushkin",
                Name = "Onegin",
                
            },
            new BookViewModel
            {
                Id = 2,
                Author = "Tolstoy",
                Name = "War & Peace",
                
            }
        };

        public IEnumerable<BookViewModel> GetAll()
        {
            return _books;
        }

        public BookViewModel GetById(int id)
        {
            return _books.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Commit()
        {
            //throw new NotImplementedException();
        }

        public void AddNew(BookViewModel model)
        {
            model.Id = _books.Max(e => e.Id) + 1;
            _books.Add(model);
        }

        public void Delete(int id)
        {
            var book = GetById(id);
            if (book is null)
                return ;

            _books.Remove(book);
        }
    }
}
