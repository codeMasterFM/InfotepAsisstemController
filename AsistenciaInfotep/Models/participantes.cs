using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotepAssistControl.Models
{
    internal class participantes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public string cedula { get; set;}
        public int cursoID { get; set; }
        public int active { get; set; }
        public DateTime fechaCreado { get; set; }
        public DateTime fechaEditado { get; set; }
        public DateTime fechaEliminado { get; set; }
    }
}
