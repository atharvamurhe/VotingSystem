using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.DAL.Data.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Voter ID")]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Select Candidate")]
        public int CandidateId { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty("Vote")]
        public virtual Candidate Candidate { get; set; }
    }
}
