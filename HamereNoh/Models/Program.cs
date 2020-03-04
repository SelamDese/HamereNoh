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
        public int BatchId { get; set; }
        public int CourceId { get; set; }
        public Cource Cource { get; set; }
        public Batch Batch { get; set; }
        public List<Cource> Cources { get; set; }
    }
}
