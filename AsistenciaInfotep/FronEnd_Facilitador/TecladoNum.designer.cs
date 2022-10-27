namespace infotepAssistControl.FronEnd_Facilitador
{
    partial class TecladoNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TecladoNum));
            this.texcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNEntrar = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN7 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // texcodigo
            // 
            this.texcodigo.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texcodigo.Location = new System.Drawing.Point(146, 118);
            this.texcodigo.Name = "texcodigo";
            this.texcodigo.Size = new System.Drawing.Size(180, 30);
            this.texcodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.texcodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 534);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.BTNEntrar);
            this.panel2.Controls.Add(this.BTN0);
            this.panel2.Controls.Add(this.BTN9);
            this.panel2.Controls.Add(this.BTN8);
            this.panel2.Controls.Add(this.BTN7);
            this.panel2.Controls.Add(this.BTN6);
            this.panel2.Controls.Add(this.BTN5);
            this.panel2.Controls.Add(this.BTN4);
            this.panel2.Controls.Add(this.BTN3);
            this.panel2.Controls.Add(this.BTN2);
            this.panel2.Controls.Add(this.BTN1);
            this.panel2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(131, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 315);
            this.panel2.TabIndex = 2;
            // 
            // BTNEntrar
            // 
            this.BTNEntrar.Location = new System.Drawing.Point(96, 215);
            this.BTNEntrar.Name = "BTNEntrar";
            this.BTNEntrar.Size = new System.Drawing.Size(156, 56);
            this.BTNEntrar.TabIndex = 10;
            this.BTNEntrar.Text = "Registrar";
            this.BTNEntrar.UseVisualStyleBackColor = true;
            this.BTNEntrar.Click += new System.EventHandler(this.BTNEntrar_Click);
            // 
            // BTN0
            // 
            this.BTN0.Location = new System.Drawing.Point(15, 215);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(75, 56);
            this.BTN0.TabIndex = 9;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = true;
            this.BTN0.Click += new System.EventHandler(this.BTN0_Click);
            // 
            // BTN9
            // 
            this.BTN9.Location = new System.Drawing.Point(177, 146);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(75, 54);
            this.BTN9.TabIndex = 8;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = true;
            this.BTN9.Click += new System.EventHandler(this.BTN9_Click);
            // 
            // BTN8
            // 
            this.BTN8.Location = new System.Drawing.Point(96, 146);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(75, 54);
            this.BTN8.TabIndex = 7;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = true;
            this.BTN8.Click += new System.EventHandler(this.BTN8_Click);
            // 
            // BTN7
            // 
            this.BTN7.Location = new System.Drawing.Point(15, 146);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(75, 54);
            this.BTN7.TabIndex = 6;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = true;
            this.BTN7.Click += new System.EventHandler(this.BTN7_Click);
            // 
            // BTN6
            // 
            this.BTN6.Location = new System.Drawing.Point(177, 83);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(75, 47);
            this.BTN6.TabIndex = 5;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = true;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // BTN5
            // 
            this.BTN5.Location = new System.Drawing.Point(96, 83);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(75, 47);
            this.BTN5.TabIndex = 4;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = true;
            this.BTN5.Click += new System.EventHandler(this.BTN5_Click);
            // 
            // BTN4
            // 
            this.BTN4.Location = new System.Drawing.Point(15, 83);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(75, 47);
            this.BTN4.TabIndex = 3;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = true;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN3
            // 
            this.BTN3.Location = new System.Drawing.Point(177, 17);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(75, 51);
            this.BTN3.TabIndex = 2;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = true;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // BTN2
            // 
            this.BTN2.Location = new System.Drawing.Point(96, 17);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(75, 51);
            this.BTN2.TabIndex = 1;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(15, 17);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(75, 51);
            this.BTN1.TabIndex = 0;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // TecladoNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 534);
            this.Controls.Add(this.panel1);
            this.Name = "TecladoNum";
            this.Text = "TecladoNum";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox texcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNEntrar;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}