using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Controllers
{
    public class LibrarycardController: Controller
    {
        BookDbContext db;
        public LibrarycardController(BookDbContext context)
        {
            this.db=context;
        }

        public IActionResult Index()
        {
            var cardList=db.Librarycards;
            return View(cardList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Librarycard lc)
        {
            db.Librarycards.Add(lc);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult DisplayBooksForLibraryCard(int libraryCardId)
        {
            var libraryCard=db.Books.Where (lc=>lc.LibrarycardId==libraryCardId);
            return View(libraryCard);
        }
        
    }
}