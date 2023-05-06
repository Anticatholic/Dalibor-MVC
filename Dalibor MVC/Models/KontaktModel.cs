using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dalibor_MVC.Models
{
    public class KontaktModel
    {
        [Required(ErrorMessage = "Prosím vyplňte svoje meno a priezvisko")]
        [Display(Name ="Meno a Priezvisko")]
        public string Meno { get; set; }


        [Required(ErrorMessage = "Prosím zadajte svoj email")]
        [Display(Name = "Email")]
        [Email(ErrorMessage ="Nesprávny formát emailu, prosím skontrolujte správnosť zápisu")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosím zadajte svoje telefónne číslo")]
        [Display(Name = "Telefón")]
        public string Telefon { get; set; }
    }
}