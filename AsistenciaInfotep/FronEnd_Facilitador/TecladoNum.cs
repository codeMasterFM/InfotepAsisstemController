using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using infotepAssistControl.FronEnd_Facilitador.clases;

namespace infotepAssistControl.FronEnd_Facilitador
{

    public partial class TecladoNum : Form
    {
        //Instancia de la api para validar aistencia de maestro
        AsistenciaFacilitador.FacilitadorAPI facilitadorAPI = new AsistenciaFacilitador.FacilitadorAPI();
      

        public TecladoNum()
        {
            InitializeComponent();

            
        }

        //region de numeros del taclado
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = "";
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "2";
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "3";
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "4";
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "5";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "6";
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "7";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "8";
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "9";
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            this.texcodigo.Text = this.texcodigo.Text + "0";
        }
        #endregion

        //evento para ingresar los datos de los textbox que se tenga en los form

        public async Task Validar() {

          //  await AsistenciaFacilitador.FacilitadorAPI.MyApi(clases.datos_Facilitador.Codigo, clases.datos_Facilitador.Cedula);

            if (await AsistenciaFacilitador.FacilitadorAPI.GetMateria(datos_Facilitador.Codigo) ==true)
              {

                await AsistenciaFacilitador.FacilitadorAPI.MyApi(clases.datos_Facilitador.Codigo, clases.datos_Facilitador.Cedula);
                MessageBox.Show("registrado");
               // new Notificaciones.controller.TelgramController().apiTelegram(datos_Facilitador.Cedula,DateTime.Now.ToString("dd/mm/yyyy"));
                this.Hide();
                FronEnd_Facilitador.FrontFacilitador front = new FronEnd_Facilitador.FrontFacilitador();
                front.Show();
            }
            else if(await AsistenciaFacilitador.FacilitadorAPI.GetMateria(datos_Facilitador.Codigo) == false)
            {
              
                MessageBox.Show("el codigo no se encunetra o esta Erroneo");

            }

        }

        private async void BTNEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.texcodigo.Text == "") {
                    MessageBox.Show("Favor ingrese el codigo de su aula");
                    

                }
                else{

                    clases.datos_Facilitador.Codigo = this.texcodigo.Text;
                    await this.Validar();

                 //   MessageBox.Show("se ha registrado con éxito");

                }
             

            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
            
            }

        }
        //boton para ir a la ventana principal escondiendo el el teclado
        private void button2_Click(object sender, EventArgs e)
        {
            FronEnd_Facilitador.FrontFacilitador front = new FrontFacilitador();
            front.Show();
            this.Hide();
        }
    }
}
