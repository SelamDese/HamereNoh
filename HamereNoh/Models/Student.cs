using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int BatchId { get; set; }
        public ProgramT Program { get; set; }
        public Batch Batch { get; set; }
        public Cource Cource { get; set; }
        public Library Library { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Cource> Cources { get; set; }
    }
}
