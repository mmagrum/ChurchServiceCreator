using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchServiceCreator.Models
{
    internal class SongMatch
    {
        public string songTitle { get; set; }  
        public string author { get; set; }
        public string? lastScheduled {  get; set; }
        public string themes { get; set; }
    }
}
