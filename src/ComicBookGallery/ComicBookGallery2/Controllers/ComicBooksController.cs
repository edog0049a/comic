using ComicBookGallery2.Data;
using ComicBookGallery2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ComicBookGallery2.Controllers
{
    public class ComicBooksController : Controller
      {
        private ComicBookRepository _comicBookReposoitory = null;

        public ComicBooksController ()
        {
            _comicBookReposoitory = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookReposoitory.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult  Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookReposoitory.GetComicBook(id.Value);
                      
            return View(comicBook);
        }

    }
}
