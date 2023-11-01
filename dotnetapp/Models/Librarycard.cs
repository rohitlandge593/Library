using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Librarycard
    {
        
        public int Id{get;set;}
        [Required]
        [RegularExpression(@"^LC-\d{5}$")]
        public string? CardNumber{get;set;}
        [Required]
        [MaxLength(100)]
        public string? MemberName{get;set;}
        public DateTime ExpiryDate{get;set;}
        public ICollection<Book> bk{get;set;}

    }
}