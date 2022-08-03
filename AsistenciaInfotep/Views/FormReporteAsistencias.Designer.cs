namespace infotepAssistControl
{
	partial class FormReporteAsistencias
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.infotedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.infotedbDataSet = new infotepAssistControl.infotedbDataSet();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbxFiltros = new System.Windows.Forms.GroupBox();
			this.btnFiltroNombre = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cbxCurso = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxNombre = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelSubmenuReporte = new System.Windows.Forms.Panel();
			this.panelFechaPersonalizada = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnPersonalizado = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btn7Dias = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnHoy = new System.Windows.Forms.Button();
			this.btnAplicar = new System.Windows.Forms.Button();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.infotedbDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.infotedbDataSet)).BeginInit();
			this.panel1.SuspendLayout();
			this.gbxFiltros.SuspendLayout();
			this.panelSubmenuReporte.SuspendLayout();
			this.panelFechaPersonalizada.SuspendLayout();
			this.SuspendLayout();
			// 
			// infotedbDataSetBindingSource
			// 
			this.infotedbDataSetBindingSource.DataSource = this.infotedbDataSet;
			this.infotedbDataSetBindingSource.Position = 0;
			// 
			// infotedbDataSet
			// 
			this.infotedbDataSet.DataSetName = "infotedbDataSet";
			this.infotedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
			this.panel1.Controls.Add(this.gbxFiltros);
			this.panel1.Controls.Add(this.panelSubmenuReporte);
			this.panel1.Controls.Add(this.btnAplicar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(246, 694);
			this.panel1.TabIndex = 0;
			// 
			// gbxFiltros
			// 
			this.gbxFiltros.Controls.Add(this.btnFiltroNombre);
			this.gbxFiltros.Controls.Add(this.btnBuscar);
			this.gbxFiltros.Controls.Add(this.cbxCurso);
			this.gbxFiltros.Controls.Add(this.label2);
			this.gbxFiltros.Controls.Add(this.cbxNombre);
			this.gbxFiltros.Controls.Add(this.label1);
			this.gbxFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbxFiltros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
			this.gbxFiltros.ForeColor = System.Drawing.Color.Black;
			this.gbxFiltros.Location = new System.Drawing.Point(14, 327);
			this.gbxFiltros.Name = "gbxFiltros";
			this.gbxFiltros.Size = new System.Drawing.Size(229, 228);
			this.gbxFiltros.TabIndex = 12;
			this.gbxFiltros.TabStop = false;
			this.gbxFiltros.Text = "Filtros";
			// 
			// btnFiltroNombre
			// 
			this.btnFiltroNombre.BackColor = System.Drawing.Color.Gray;
			this.btnFiltroNombre.ForeColor = System.Drawing.Color.Black;
			this.btnFiltroNombre.Location = new System.Drawing.Point(151, 190);
			this.btnFiltroNombre.Name = "btnFiltroNombre";
			this.btnFiltroNombre.Size = new System.Drawing.Size(75, 32);
			this.btnFiltroNombre.TabIndex = 11;
			this.btnFiltroNombre.Text = "Buscar";
			this.btnFiltroNombre.UseVisualStyleBackColor = false;
			this.btnFiltroNombre.Click += new System.EventHandler(this.btnFiltroNombre_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(200, 325);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(95, 34);
			this.btnBuscar.TabIndex = 9;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// cbxCurso
			// 
			this.cbxCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
			this.cbxCurso.ForeColor = System.Drawing.Color.White;
			this.cbxCurso.FormattingEnabled = true;
			this.cbxCurso.Location = new System.Drawing.Point(11, 132);
			this.cbxCurso.Name = "cbxCurso";
			this.cbxCurso.Size = new System.Drawing.Size(214, 26);
			this.cbxCurso.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Curso";
			// 
			// cbxNombre
			// 
			this.cbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
			this.cbxNombre.ForeColor = System.Drawing.Color.Black;
			this.cbxNombre.FormattingEnabled = true;
			this.cbxNombre.Location = new System.Drawing.Point(11, 68);
			this.cbxNombre.Name = "cbxNombre";
			this.cbxNombre.Size = new System.Drawing.Size(212, 26);
			this.cbxNombre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre :";
			// 
			// panelSubmenuReporte
			// 
			this.panelSubmenuReporte.Controls.Add(this.panelFechaPersonalizada);
			this.panelSubmenuReporte.Controls.Add(this.panel8);
			this.panelSubmenuReporte.Controls.Add(this.btnPersonalizado);
			this.panelSubmenuReporte.Controls.Add(this.panel7);
			this.panelSubmenuReporte.Controls.Add(this.btn7Dias);
			this.panelSubmenuReporte.Controls.Add(this.panel6);
			this.panelSubmenuReporte.Controls.Add(this.btnHoy);
			this.panelSubmenuReporte.Location = new System.Drawing.Point(12, 39);
			this.panelSubmenuReporte.Name = "panelSubmenuReporte";
			this.panelSubmenuReporte.Size = new System.Drawing.Size(228, 248);
			this.panelSubmenuReporte.TabIndex = 11;
			// 
			// panelFechaPersonalizada
			// 
			this.panelFechaPersonalizada.Controls.Add(this.panel4);
			this.panelFechaPersonalizada.Controls.Add(this.panel3);
			this.panelFechaPersonalizada.Controls.Add(this.label7);
			this.panelFechaPersonalizada.Controls.Add(this.label6);
			this.panelFechaPersonalizada.Controls.Add(this.dateTimePicker4);
			this.panelFechaPersonalizada.Controls.Add(this.dateTimePicker1);
			this.panelFechaPersonalizada.ForeColor = System.Drawing.Color.Black;
			this.panelFechaPersonalizada.Location = new System.Drawing.Point(3, 117);
			this.panelFechaPersonalizada.Name = "panelFechaPersonalizada";
			this.panelFechaPersonalizada.Size = new System.Drawing.Size(222, 120);
			this.panelFechaPersonalizada.TabIndex = 12;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel4.Location = new System.Drawing.Point(6, 45);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(5, 32);
			this.panel4.TabIndex = 17;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel3.Location = new System.Drawing.Point(6, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(5, 32);
			this.panel3.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(17, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "Hasta :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(17, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Desde :";
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker4.Location = new System.Drawing.Point(79, 57);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.Size = new System.Drawing.Size(143, 20);
			this.dateTimePicker4.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(79, 18);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel8.Location = new System.Drawing.Point(0, 79);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(5, 32);
			this.panel8.TabIndex = 15;
			// 
			// btnPersonalizado
			// 
			this.btnPersonalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
			this.btnPersonalizado.FlatAppearance.BorderSize = 0;
			this.btnPersonalizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPersonalizado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPersonalizado.ForeColor = System.Drawing.Color.Black;
			this.btnPersonalizado.Location = new System.Drawing.Point(3, 79);
			this.btnPersonalizado.Name = "btnPersonalizado";
			this.btnPersonalizado.Size = new System.Drawing.Size(219, 32);
			this.btnPersonalizado.TabIndex = 14;
			this.btnPersonalizado.Text = "Personalizado";
			this.btnPersonalizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPersonalizado.UseVisualStyleBackColor = false;
			this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel7.Location = new System.Drawing.Point(0, 41);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(5, 32);
			this.panel7.TabIndex = 13;
			// 
			// btn7Dias
			// 
			this.btn7Dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
			this.btn7Dias.FlatAppearance.BorderSize = 0;
			this.btn7Dias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btn7Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn7Dias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7Dias.ForeColor = System.Drawing.Color.Black;
			this.btn7Dias.Location = new System.Drawing.Point(3, 41);
			this.btn7Dias.Name = "btn7Dias";
			this.btn7Dias.Size = new System.Drawing.Size(219, 32);
			this.btn7Dias.TabIndex = 12;
			this.btn7Dias.Text = "Los últimos 7 días";
			this.btn7Dias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn7Dias.UseVisualStyleBackColor = false;
			this.btn7Dias.Click += new System.EventHandler(this.btn7Dias_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel6.Location = new System.Drawing.Point(0, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(5, 32);
			this.panel6.TabIndex = 11;
			// 
			// btnHoy
			// 
			this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
			this.btnHoy.FlatAppearance.BorderSize = 0;
			this.btnHoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHoy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHoy.ForeColor = System.Drawing.Color.Black;
			this.btnHoy.Location = new System.Drawing.Point(3, 3);
			this.btnHoy.Name = "btnHoy";
			this.btnHoy.Size = new System.Drawing.Size(219, 32);
			this.btnHoy.TabIndex = 10;
			this.btnHoy.Text = "Hoy";
			this.btnHoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHoy.UseVisualStyleBackColor = false;
			this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
			// 
			// btnAplicar
			// 
			this.btnAplicar.BackColor = System.Drawing.Color.Gray;
			this.btnAplicar.ForeColor = System.Drawing.Color.Black;
			this.btnAplicar.Location = new System.Drawing.Point(165, 289);
			this.btnAplicar.Name = "btnAplicar";
			this.btnAplicar.Size = new System.Drawing.Size(75, 32);
			this.btnAplicar.TabIndex = 10;
			this.btnAplicar.Text = "Buscar";
			this.btnAplicar.UseVisualStyleBackColor = false;
			this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "infotepAssistControl.ReportAsistencias.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(246, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(772, 694);
			this.reportViewer1.TabIndex = 1;
			// 
			// FormReporteAsistencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 694);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.panel1);
			this.Name = "FormReporteAsistencias";
			this.Text = "FormReporteAsistencias";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormReporteAsistencias_Load);
			((System.ComponentModel.ISupportInitialize)(this.infotedbDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.infotedbDataSet)).EndInit();
			this.panel1.ResumeLayout(false);
			this.gbxFiltros.ResumeLayout(false);
			this.gbxFiltros.PerformLayout();
			this.panelSubmenuReporte.ResumeLayout(false);
			this.panelFechaPersonalizada.ResumeLayout(false);
			this.panelFechaPersonalizada.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.Panel panelSubmenuReporte;
		private System.Windows.Forms.Panel panelFechaPersonalizada;
		private System.Windows.Forms.Button btnAplicar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button btnPersonalizado;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button btn7Dias;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btnHoy;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox gbxFiltros;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ComboBox cbxCurso;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource infotedbDataSetBindingSource;
		private infotedbDataSet infotedbDataSet;
		private System.Windows.Forms.Button btnFiltroNombre;
	}
}