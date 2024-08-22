using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchServiceCreator.Models
{
    public class appConfig
    {
        public string appId { get; set; }
        public string secret { get; set; }
        public string url {  get; set; }
        public int lastSungMonths { get; set; }
        public int resultsReturned { get; set; }
    }
}
