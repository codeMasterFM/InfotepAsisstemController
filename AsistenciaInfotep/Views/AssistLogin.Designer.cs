namespace infotepAssistControl.Views
{
	partial class AssistLogin
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
			this.TitleBar = new System.Windows.Forms.Panel();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.TitleBar.Controls.Add(this.btnMinimizar);
			this.TitleBar.Controls.Add(this.btnCerrar);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(1012, 50);
			this.TitleBar.TabIndex = 0;
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimizar.Image = global::infotepAssistControl.Properties.Resources.Minimize_Icon;
			this.btnMinimizar.Location = new System.Drawing.Point(923, 0);
			this.btnMinimizar.Margin = new System.Windows.Forms.Padding(10, 10, 50, 10);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Padding = new System.Windows.Forms.Padding(10);
			this.btnMinimizar.Size = new System.Drawing.Size(45, 50);
			this.btnMinimizar.TabIndex = 1;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCerrar.Image = global::infotepAssistControl.Properties.Resources.Close_Icon;
			this.btnCerrar.Location = new System.Drawing.Point(968, 0);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(50);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Padding = new System.Windows.Forms.Padding(10);
			this.btnCerrar.Size = new System.Drawing.Size(44, 50);
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 663);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1012, 40);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(48, 16);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.label1.Size = new System.Drawing.Size(90, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Silver;
			this.label2.Location = new System.Drawing.Point(48, 110);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label2.Size = new System.Drawing.Size(137, 36);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña";
			// 
			// txtContrasena
			// 
			this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContrasena.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
			this.txtContrasena.ForeColor = System.Drawing.Color.White;
			this.txtContrasena.Location = new System.Drawing.Point(53, 158);
			this.txtContrasena.Multiline = true;
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.Size = new System.Drawing.Size(350, 40);
			this.txtContrasena.TabIndex = 5;
			this.txtContrasena.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(53, 218);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(350, 46);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.White;
			this.txtUsuario.Location = new System.Drawing.Point(53, 58);
			this.txtUsuario.Multiline = true;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.PasswordChar = '*';
			this.txtUsuario.Size = new System.Drawing.Size(350, 40);
			this.txtUsuario.TabIndex = 7;
			this.txtUsuario.UseSystemPasswordChar = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtUsuario);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.txtContrasena);
			this.panel2.Location = new System.Drawing.Point(500, 204);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(450, 320);
			this.panel2.TabIndex = 8;
			// 
			// AssistLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
			this.ClientSize = new System.Drawing.Size(1012, 703);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TitleBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AssistLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AssistLogin";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.TitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.PictureBox btnMinimizar;
		private System.Windows.Forms.PictureBox btnCerrar;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Panel panel2;
	}
}