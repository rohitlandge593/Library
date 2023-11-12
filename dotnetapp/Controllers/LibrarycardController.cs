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
        public IActionResult DisplayBooksForLibraryCard()
        {
            var v=db.Librarycards.Include("Books");
            TempData["State"]=0;
            return View(v);
            
        }
        [HttpPost]
        public IActionResult DisplayBooksForLibraryCard(string libraryCardIdStr)
        {
            int libraryCardId=Convert.ToInt32(libraryCardIdStr);

            TempData["State"]=1;
            var libraryCard=db.Librarycards.Where (lc=>lc.Id==libraryCardId);
            return View(libraryCard);
        }
        
    }
}