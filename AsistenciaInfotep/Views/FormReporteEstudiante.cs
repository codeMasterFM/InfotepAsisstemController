using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infotepAssistControl.Views
{
	public partial class FormReporteEstudiante : Form
	{
		infotedbEntities infotedbEntities = new infotedbEntities();
		object fecha;

		public string Fecha1;
		public string Fecha2;
		public string NombreEstudiante;
		public string CursoEstudiante;
		public FormReporteEstudiante()
		{
			InitializeComponent();
		}

		private void FormReporteEstudiante_Load(object sender, EventArgs e)
		{
			this.reportViewer1.LocalReport.ReportPath = "ReportAsistenciaEstudiantes.rdlc";
			Fecha1 = DateTime.Today.ToString();
			Fecha2 = DateTime.Today.ToString();

			ReportParameter[] Parametros = new ReportParameter[2];
			Parametros[0] = new ReportParameter("FechaDesde", DateTime.Today.ToString());
			Parametros[1] = new ReportParameter("FechaHasta", DateTime.Today.ToString());
			reportViewer1.LocalReport.SetParameters(Parametros);
			reportViewer1.LocalReport.DataSources.Clear();
			this.reportViewer1.RefreshReport();
		}

		private void btnHoy_Click(object sender, EventArgs e)
		{
			Fecha1 = DateTime.Today.ToString();
			Fecha2 = DateTime.Today.ToString();

			ReportParameter[] Parametros = new ReportParameter[2];
			Parametros[0] = new ReportParameter("FechaDesde", Fecha1);
			Parametros[1] = new ReportParameter("FechaHasta", Fecha2);
			reportViewer1.LocalReport.SetParameters(Parametros);
			using (infotedbEntities conexion = new infotedbEntities())
			{
				fecha = conexion.Rango_Fecha_Participante(DateTime.Parse(Fecha1).Date, DateTime.Parse(Fecha2).Date).
					ToList<Rango_Fecha_Participante_Result>();
			}
			this.reportViewer1.LocalReport.ReportPath = "ReportAsistenciaEstudiantes.rdlc";
			ReportDataSource source = new ReportDataSource("DataSet1", fecha);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(source);
			this.reportViewer1.RefreshReport();
		}

		private void btn7Dias_Click(object sender, EventArgs e)
		{
			Fecha1 = DateTime.Today.AddDays(-7).ToString();
			Fecha2 = DateTime.Today.ToString();
			using (infotedbEntities conexion = new infotedbEntities())
			{
				fecha = conexion.Rango_Fecha_Participante(DateTime.Parse(Fecha1), DateTime.Parse(Fecha2)).
					ToList<Rango_Fecha_Participante_Result>();
			}

			this.reportViewer1.LocalReport.ReportPath = "ReportAsistenciaEstudiantes.rdlc";
			ReportDataSource source = new ReportDataSource("DataSet1", fecha);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(source);

			ReportParameter[] Parametros = new ReportParameter[2];
			Parametros[0] = new ReportParameter("FechaDesde", Fecha1);
			Parametros[1] = new ReportParameter("FechaHasta", Fecha2);
			reportViewer1.LocalReport.SetParameters(Parametros);
			this.reportViewer1.RefreshReport();
		}

		private void btnPersonalizado_Click(object sender, EventArgs e)
		{
			panelFechaPersonalizada.Visible = true;
		}

		private void btnAplicar_Click(object sender, EventArgs e)
		{
			Fecha1 = dateTimePicker1.Value.ToShortDateString();
			Fecha2 = dateTimePicker4.Value.ToShortDateString();
			using (infotedbEntities conexion = new infotedbEntities())
			{
				fecha = conexion.Rango_Fecha_Participante(DateTime.Parse(Fecha1), DateTime.Parse(Fecha2)).
								ToList<Rango_Fecha_Participante_Result>();
			}
			this.reportViewer1.LocalReport.ReportPath = "ReportAsistenciaEstudiantes.rdlc";
			ReportDataSource source = new ReportDataSource("DataSet1", fecha);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(source);
			ReportParameter[] Parametros = new ReportParameter[2];
			Parametros[0] = new ReportParameter("FechaDesde", Fecha1);
			Parametros[1] = new ReportParameter("FechaHasta", Fecha2);
			reportViewer1.LocalReport.SetParameters(Parametros);
			this.reportViewer1.RefreshReport();
		}

		private void btnFiltroNombre_Click(object sender, EventArgs e)
		{
			NombreEstudiante = cbxNombre.Text;
			CursoEstudiante = cbxCurso.Text;
			ReportParameter[] ParametrosFiltro = new ReportParameter[2];
			ParametrosFiltro[0] = new ReportParameter("NombreEstudiante", NombreEstudiante);
			ParametrosFiltro[1] = new ReportParameter("CursoEstudiante", CursoEstudiante);
			reportViewer1.LocalReport.SetParameters(ParametrosFiltro);
			this.reportViewer1.RefreshReport();
		}
	}
}
