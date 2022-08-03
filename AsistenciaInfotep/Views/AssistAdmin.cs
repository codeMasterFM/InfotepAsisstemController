using infotepAssistControl.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace infotepAssistControl.Views
{
	public partial class AssistAdmin : Form
	{
		//MySqlConnection conexion = new MySqlConnection("Server=localhost; User Id=root; Password=''; Database=api_cursos");

		public SqlConnection conexion2 = new SqlConnection(@"server = (localdb)\MSSQLLocalDB;" +
											"database = infotedb; integrated security = true");
		public  void conectar()
		{
			conexion2.Open();
		}
		public void desconectar()
		{
			conexion2.Close();
		}

		string urlMaestro = "http://localhost/ApiAssisControlInfotep/Api-Cursos/public/api/maestro";
		string urlParticipantes = "http://localhost/ApiAssisControlInfotep/Api-Cursos/public/api/participante";
		public AssistAdmin()
		{
			InitializeComponent();
			panelSubmenuListas.Visible = false;
		}
	   //traer los datos de la api
		public async Task<string> GetHttpMaestro()
		{
			WebRequest oRequest = WebRequest.Create(urlMaestro);
			WebResponse oResponse = oRequest.GetResponse();
			StreamReader sr = new StreamReader(oResponse.GetResponseStream());
			return await sr.ReadToEndAsync();
		}
		public async Task<string> GetHttpParticipantes()
		{
			WebRequest oRequest = WebRequest.Create(urlParticipantes);
			WebResponse oResponse = oRequest.GetResponse();
			StreamReader sr = new StreamReader(oResponse.GetResponseStream());
			return await sr.ReadToEndAsync();
		}

		//llenar el datagrid con la asistencia de los facilitadores
		public void btnAsistenciasFacilitadores_Click(object sender, EventArgs e)
		{
			panelFechaBusqueda.Visible = true;
			panelSubmenuListas.Visible = false;
			panelFechaBusqueda.Visible = true;
			conectar();
			string select = "select * from asistencia_facilitador";
			SqlCommand command = new SqlCommand(select,conexion2);
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgvAsistenciaFacilitadores.DataSource = dt;
			desconectar();
		}

		//llenar el datagrid con la asistencia de los participantes
		public void btnAsistenciasEstudiantes_Click(object sender, EventArgs e)
		{
			panelFechaBusqueda.Visible = true;
			panelSubmenuListas.Visible = false;
			panelFechaBusqueda.Visible = true;
			this.gbxFiltros.Size = new System.Drawing.Size(301, 295);
			this.btnBuscar.Location = new System.Drawing.Point(200, 255);
			conectar();
			string select = "select * from asistencia_participante";
			SqlCommand command = new SqlCommand(select, conexion2);
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dgvAsistenciaFacilitadores.DataSource = dt;
			desconectar();
		} 
		private void btnListas_Click(object sender, EventArgs e)
		{
			panelSubmenuListas.Visible = true;
			panelFechaBusqueda.Visible = false;
			this.btnBuscar.Location = new System.Drawing.Point(200, 100);
		}
		//Listados de los registros de los facilitadores
		public async void btnListaFacilitadores_Click(object sender, EventArgs e)
		{
			string respuesta = await GetHttpMaestro();
			List<Maestro> listaFacilitadores = JsonConvert.DeserializeObject<List<Maestro>>(respuesta);
			dgvAsistenciaFacilitadores.DataSource = listaFacilitadores;
		}
		//Listados de los registros de los estudiantes
		public async void btnListaEstudiantes_Click(object sender, EventArgs e)
		{
			panelFechaBusqueda.Visible = false;
			string respuesta = await GetHttpParticipantes();
			List<Maestro> listaParticipantes = JsonConvert.DeserializeObject<List<Maestro>>(respuesta);
			dgvAsistenciaFacilitadores.DataSource = listaParticipantes;
		}
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnReporteFacilitadores_Click(object sender, EventArgs e)
		{

			FormReporteAsistencias formReporteAsistencias = new FormReporteAsistencias();		
			formReporteAsistencias.ShowDialog();
		}

		private void btnReporteEstudiantes_Click(object sender, EventArgs e)
		{
			FormReporteEstudiante FormReporteEstudiante = new FormReporteEstudiante();
			FormReporteEstudiante.ShowDialog();
		}

		private void txtBuscador_TextChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow Row in dgvAsistenciaFacilitadores.Rows)
			{
				String strFila = Row.Index.ToString();
				string Valor = Convert.ToString(Row.Cells["nombre"].Value);

				if (Valor == this.txtBuscador.Text)
				{
					dgvAsistenciaFacilitadores.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Green;
				}
			}
			//dgvAsistenciaFacilitadores = $"contacto LIKE '{txtBuscador.Text}%'";
			//string TextToSearch = txtBuscador.Text;
			//BindingSource bs = new BindingSource();
			//bs.DataSource = dgvAsistenciaFacilitadores.DataSource;
			//bs.Filter = $"[nombre] LIKE '%'{TextToSearch}'%'";
			//bs.Filter = $"[nombre] LIKE '%'{TextToSearch}'%' AND [apellido] LIKE '%'{TextToSearch}'%'";
			//dgvAsistenciaFacilitadores.DataSource = bs;
		}

		private void btnEnviarReportes_Click(object sender, EventArgs e)
		{
			Gmail gmail = new Gmail();
			gmail.ShowDialog();
		}


		/*private void ocultarDefault()
		{
			panelListaAsistencias.Visible = false;
			panelSubmenuReportes.Visible = false;
			panelSubmenuListaAsistencia.Visible = false;
		}

		private void ocultar()
		{
			if(panelListaAsistencias.Visible == true) panelListaAsistencias.Visible = false;
			if (panelSubmenuReportes.Visible == true) panelSubmenuReportes.Visible = false;
			if(panelSubmenuListaAsistencia.Visible == true) panelSubmenuListaAsistencia.Visible = false;
		}

		private void mostrar(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				ocultar();
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
		}*/

	}
}
