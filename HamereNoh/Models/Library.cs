using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public string UserId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Batch Batch { get; set; }
        public Cource Cource { get; set; }
        public ProgramT Program { get; set; }
        public ApplicationUser User { get; set; }
    }
}
