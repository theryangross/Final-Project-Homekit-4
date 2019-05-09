using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project_Homekit_4.Models;



namespace Final_Project_Homekit_4.Pages
{
    public class QuestionsModel : PageModel
    {
        private readonly ILogger _log;

        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;}

        [BindProperty]
        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "The E-Mail field is not valid.")]
        public string Email {get; set;}

        [BindProperty]
        [Required]
        [Display(Name = "Question")]
        public string Question {get; set;}

        public QuestionsModel(ILogger<QuestionsModel> log)
        {
            _log = log;
        }

         public void OnPost()
        {
          _log.LogInformation($"IndexModel OnGet( {FirstName} ) Called",FirstName);
        }

        public void OnGet()
        {
            
        }

       
    }
}