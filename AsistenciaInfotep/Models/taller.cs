using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotepAssistControl.Models
{
    internal class taller
    {
        public int id { get; set; }
        public string nombre{ get; set; }
        public string ubicacion { get; set; }
        public int active { get; set; }
        public DateTime fechaCreado { get; set; }
        public DateTime fechaEditado { get; set; }
        public DateTime fechaEliminado { get; set; }

    }
}
