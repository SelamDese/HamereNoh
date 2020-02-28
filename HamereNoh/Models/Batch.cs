using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Batch
    {
        [Key]
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public int ProgramId { get; set; }
    }
}
