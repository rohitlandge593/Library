using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class BookController: Controller
    {
        BookDbContext db;
        public BookController(BookDbContext context)
        {
            this.db=context;
        }
        public IActionResult Index()
        {
            var bookList=db.Books;
            return View(bookList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book bk)
        {
            db.Books.Add(bk);
            db.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}