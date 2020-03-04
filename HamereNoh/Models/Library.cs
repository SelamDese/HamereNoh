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
        public int BatchId { get; set; }
        public int CourceId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
