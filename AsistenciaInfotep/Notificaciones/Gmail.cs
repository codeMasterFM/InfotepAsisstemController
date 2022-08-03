using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using infotepAssistControl.controller;
using Newtonsoft.Json;

namespace infotepAssistControl
{
    public partial class Gmail : Form
    {
        infotedbEntities db = new infotedbEntities();
        correos  correo = new correos();
        int id;
        //SmtpClient smtpClient = null;
        //static List<string> correos = new List<string>();
        
        public Gmail()
        {
            InitializeComponent();
            //crud();
            //leer();
            mostral();

        }


        #region no utilizar
        /*
                public void abril_archivos()
                {

                    OpenFileDialog ofd = new OpenFileDialog();
                    direccion = ofd.FileName;
                    ofd.ShowDialog();
                    MessageBox.Show(ofd.FileName);


                }

                public void crud()
                {
                    controller.CrudController crudtxt = new controller.CrudController();
                    crudtxt.crearTXT();
                }

                public void agreagar() { 

                    CrudController crudtxt = new CrudController();
                    crudtxt.escribirTXT(textBox1.Text);

                }

                public void leer()
                {

                     CrudController crudtxt = new CrudController();
                   // crudtxt.leer();
                   // foreach (var item in crudtxt.leer()) {
                        //correos.Add(item);
                       dataGridView1.Rows.Add();
                    foreach (string item in crudtxt.leer())
                    {
                        MessageBox.Show(item); 

                    }
                    //    MessageBox.Show(item);
                   // }           

                }
        */
        #endregion
        public void mostral() {

            //var consulta = (from correo in db.correos
            //                select new
            //                {
                                
            //                    correo.nombre,
            //                    correo.correo,
            //                    correo.id
            //                }).ToList();
            var datos = db.correos.ToList();
            dataGridView1.DataSource = datos;
        }

        #region crud
        public void agregar() {

            
            correo.nombre = tb_nombre.Text;
            correo.correo = tb_correo.Text;
            db.correos.Add(correo);
            db.SaveChanges();
            mostral();
            MessageBox.Show("Agregado");

        }
        public void modificar() {
            correo = db.correos.Find(id);
            correo.nombre = tb_nombre.Text;
            correo.correo = tb_correo.Text;
            db.Entry(correo);
            db.SaveChanges();
            MessageBox.Show("Modificado");
            mostral();
            limpiarDatos();
        }
        public void eliminar() {
          if(MessageBox.Show("Esta seguro que decea Eliminar este Registro ?","correos",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                correo = db.correos.Find(id);
                db.correos.Remove(correo);
                db.SaveChanges();
                mostral();
                limpiarDatos();
            }

        }
        public void limpiarDatos() {
            this.tb_correo.Text = "";
            this.tb_nombre.Text = "";
        
        }
        #endregion


        #region Enviar correos gmail
        public void mail()
        {

            //ESTA CONSULATA RETORNA UN LISTA DE CORREOS
            var consulta = (from correo in db.correos
                            select new
                            {
                                correo.correo
                            }).ToList();
            controller.ImailController imail = new ImailController();


            string direccion = buscar_archivo();
            if (direccion == string.Empty)
            {

                MessageBox.Show("No se a seleccionado un archivo para enviar");              
            }
            else
            {
                //ESTE  METODO RECIBE 2 PARAMETROS 
                //LOS DESTINATARIOS Y  EL ARCHIVO ADJUNTO "imail"
             

                    imail.mensajes(tb_correo.Text, direccion);
                    if (imail.mensaje == false)
                    {
                        MessageBox.Show("Enviado correctamente");
                    }

                if (imail.mensaje == true) 
                {
                    MessageBox.Show($"Este mensaje no pudo ser enviado {'\n'} Revise su conexion de internet");

                }
                      
                        
                   
                    
                
            }
        }
        #endregion


        #region Buscar Archivos
        //ESTE METODO ABRE UN DIRECTORIO PARA SELECCIONAR EL ARCHIVO A ENVIAR 
        public string buscar_archivo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //direccion = ofd.FileName;
            ofd.ShowDialog();
         //   MessageBox.Show(ofd.FileName);
        
            return ofd.FileName;
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
          //  leer();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            mail();

        }
		private void btnCerrar_Click(object sender, EventArgs e)
		{
            Application.Exit();
        }

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            agregar();
            mostral();
            limpiarDatos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            modificar();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            eliminar();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tb_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_correo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}