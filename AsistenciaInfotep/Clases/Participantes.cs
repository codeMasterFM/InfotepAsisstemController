using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotepAssistControl.Clases
{
	public class Participantes
	{
		public int id { get; set; }
		public string nombre { get; set; }
		public string apellido { get; set; }
		public int cedula { get; set; }
		public int cursoID { get; set; }
		public int active { get; set; }		
		public string fechaCreado { get; set; }
		public string fechaEditado { get; set; }
		public string fechaEliminado { get; set; }
    }
}
