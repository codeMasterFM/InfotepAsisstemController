using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotepAssistControl.Models
{
    internal class maestro_materias
    {
        public int id { get; set; }
        public int maestroID { get; set; }
        public int materiaID { get; set; }
        public int active { get; set; }
        public DateTime fechaCreado { get; set; }
        public DateTime fechaEditado { get; set; }
        public DateTime fechaEliminado { get; set; }

    }
}
