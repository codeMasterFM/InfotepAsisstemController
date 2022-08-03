using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace infotepAssistControl.Views
{
	public partial class AssistLogin : Form
	{
		public AssistLogin()
		{
			InitializeComponent();
			txtUsuario.Focus();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
		
			string usua = txtUsuario.Text;
			string clave = txtContrasena.Text;
			infotedbEntities db = new infotedbEntities();
			usuario usuario = new usuario() { usuario1 = usua,clave=clave};
			var respuesta =	db.usuario.Where(x=>x.usuario1 == usuario.usuario1 && x.clave == usuario.clave).FirstOrDefault();
			if (respuesta != null)
            {
				new AssistAdmin().ShowDialog();
            }
            else
            {
				MessageBox.Show("Usuario o Clave Incorrectos");

			}

		}
	}
}
