using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.DAL.Data.Models
{
    public class Candidate
    {
        public Candidate()
        {
            Vote = new HashSet<Vote>();
        }
        [Key]
        public int Id { get; set; }

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

        public string PhotoPath { get; set; }

        [Display(Name = "Vote Count")]
        [InverseProperty("Candidate")]
        public virtual ICollection<Vote> Vote { get; set; }

    }
}
