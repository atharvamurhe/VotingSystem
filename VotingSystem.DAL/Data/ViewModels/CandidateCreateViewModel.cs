using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.DAL.Data.ViewModels
{
    public class CandidateCreateViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a first name")]
        [MaxLength(20, ErrorMessage = "First Name cannot be more than 20 character")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a last name")]
        [MaxLength(20, ErrorMessage = "Last Name cannot be more than 20 character")]
        public string LastName { get; set; }

        [Display(Name = "Party Name")]
        [Required(ErrorMessage = "Please enter a Party name")]
        [MaxLength(30, ErrorMessage = "Party Name cannot be more than 30 character")]
        public string PartyName { get; set; }

        public IFormFile Photo { get; set; }
    }
}
