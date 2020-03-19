using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }

    }
}
