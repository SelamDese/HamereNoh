﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
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
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ProgramT Program { get; set; }
        public Batch Batch { get; set; }
        public Cource Cource { get; set; }
        public List<Student> Students { get; set; }
        public List<Cource> Cources { get; set; } 
    }
}
