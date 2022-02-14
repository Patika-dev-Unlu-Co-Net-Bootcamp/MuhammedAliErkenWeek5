using Orc.Search;
using Sieve.Attributes;
using SSPLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWeek5.Models
{
    public class Member
    {
      
        public int Id { get; set; }

        [SearchableProperty(SearchName = "firstname")]
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        [Required]
        
        [Compare("Email", ErrorMessage = "Email giriniz.")]
        public string Email { get; set; }

        [Required]
        
        [Compare("Phone", ErrorMessage = "Telefon numaranızı giriniz.")]
        public string Phone { get; set; }
        public string CreditCardType { get; set; }

        
    }
}
