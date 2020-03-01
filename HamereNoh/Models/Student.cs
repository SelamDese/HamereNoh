using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Student
    {
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

        public Program Program { get; set; }
        public Batch Batch { get; set; }
        public int ProgramId { get; set; }
        public int BatchId { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
