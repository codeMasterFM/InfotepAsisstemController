using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using infotepAssistControl.AsistenciaFacilitador;
using infotepAssistControl.AsistenciaParticipante;
using infotepAssistControl.FronEnd_Facilitador.clases;

namespace infotepAssistControl.FronEnd_Facilitador
{

    public partial class FrontFacilitador : Form
    {
        public FrontFacilitador()
        {
            InitializeComponent();
            this.panel2.Visible = false;
            texcedula.Select();

        }

        //evento changed para que llame a la ventana de teclado
        public async Task validarCedula() {


            if (this.radioButton1.Checked)
            {
                if (await ParticipanteApi.GetCedulaParticipante(texcedula.Text))
                {
                    this.panel2.Visible = true;
                    //se guarda el resultado en un atributo cedula de una clase 
                    this.texcedula.Focus();
                    clases.datos_Facilitador.Cedula = texcedula.Text;
                    await ParticipanteApi.Participante(texcedula.Text);
                    MessageBox.Show("Aistencia o Salida Registrada");
                    new Notificaciones.controller.TelgramController().apiTelegram(texcedula.Text, DateTime.Now.ToString("dd/mm/yyyy"));
                    this.texcedula.Text = "";
                }
                else
                {
                    MessageBox.Show("El participante no existe :( !!");
                }
            }
            if (this.radioButton2.Checked)
            {
                if (await FacilitadorAPI.GetFacilitador(texcedula.Text))
                {
                    this.panel2.Visible = true;
                    //se guarda el resultado en un atributo cedula de una clase 
                    clases.datos_Facilitador.Cedula = texcedula.Text;
                    this.texcedula.Focus();
                    // se llama al form
                    infotepAssistControl.FronEnd_Facilitador.TecladoNum teclado = new TecladoNum();
                    teclado.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El participante no existe :( !!");
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //infotepAssistControl.FronEnd_Facilitador.TecladoNum teclado = new TecladoNum();
            //teclado.Show();
        }    

        //private void maskedTextBox1_MaskChanged(object sender, EventArgs e)
        //{
        //    validarCedula();

        //}
        //evento de cedula del texbox
        private async void LeerCedula(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                
              await  validarCedula();
                

            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.panel2.Visible = true;
            texcedula.Select();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.panel2.Visible = true;
            texcedula.Select();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
