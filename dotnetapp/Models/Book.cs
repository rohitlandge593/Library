using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models
{
    public class Book
    {
        public int Id{get;set;}
        [MaxLength(100)]
        public string? Title{get;set;}
        [ForeignKey("Librarycard")]
         public int LibrarycardId{get;set;}
        [MaxLength(100)]
        public string? Author{get;set;}
        [Range(0,int.MaxValue)]
        public int PublishedYear{get;set;}
        public virtual Librarycard? Librarycard{get;set;}

    }
}