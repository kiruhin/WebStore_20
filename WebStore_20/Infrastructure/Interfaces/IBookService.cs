using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IBookService
    {
        
            /// <summary>
            /// Получение списка 
            /// </summary>
            /// <returns></returns>
            IEnumerable<BookViewModel> GetAll();

            /// <summary>
            /// Получение  по id
            /// </summary>
            /// <param name="id">Id</param>
            /// <returns></returns>
            BookViewModel GetById(int id);

            /// <summary>
            /// Сохранить изменения
            /// </summary>
            void Commit();

            /// <summary>
            /// Добавить нового
            /// </summary>
            /// <param name="model"></param>
            void AddNew(BookViewModel model);

            /// <summary>
            /// Удалить
            /// </summary>
            /// <param name="id"></param>
            void Delete(int id);
    }
}
