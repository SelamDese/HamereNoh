using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamereNoh.Models
{
    public class Cource
    {
        public int CourceId { get; set; }
        public int CourceName { get; set; }
        public Program Program { get; set; }
        public Batch Batch { get; set; }
    }
}
