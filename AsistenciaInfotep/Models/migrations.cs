using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotepAssistControl.Models
{
    internal class migrations
    {
        public int id { get; set; }
        public string migration { get; set; }
        public int batch { get; set; }
    }
}
