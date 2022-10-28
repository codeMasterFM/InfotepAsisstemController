using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace infotepAssistControl.AsistenciaParticipante
{
    public class ParticipanteApi
    {

        public static async Task Participante(string cedula)
        {
            // Instancia del FacilitadorModelo de la base de datos
           infotedbEntities db = new infotedbEntities();

            // Instacia del Objeto Facilitador para poder acceder a sus atributos y asignarselos
            asistencia_participante participanteModelo = new asistencia_participante();

            List<asistencia_participante> participanteLista = new List<asistencia_participante>();

            // Consulto la API pasandole los parametros de codigo y cedula.
            // Me retorna el maestro asignado a una materia junto con su codigo y cedula
            var url = $"https://localhost:7225/api/AsistenciaParticipantes/{cedula}";
            using (var httpClient = new HttpClient())
            {

                var respuesta = await httpClient.GetAsync(url);

                // Almaceno la fecha de hoy, debe de estar en una variable
                var fechaHoy = DateTime.Now.Date;

                // Me retorna una lista de objetos que conicidan con la fecha y la cedula ingresada.
                participanteLista = db.asistencia_participante.Where(x => DbFunctions.TruncateTime(x.fecha) == fechaHoy
                                    && x.cedula_participante == cedula).ToList();

                int GetId = 0;

                // Me retorna el ultimo ID del facilitador.
                foreach (var item in participanteLista)
                {
                    GetId = item.id_asis_participante;

                }

                // Condicion que comprueba el estado de la consulta al API

                switch (respuesta.StatusCode)
                {
                    // Si el estatus es ok/200 se procede a su uso
                    case System.Net.HttpStatusCode.OK:
                        var respuestaString = await respuesta.Content.ReadAsStringAsync();

                        // Convierto la respuesta del API en una lista de objetos Dinamico
                        var participante = JsonConvert.DeserializeObject<List<dynamic>>(respuestaString);

                        // Condicion para saber si existe un registro del facilitador para poder registrar su entrada o salida
                        if (GetId == 0)
                        {
                            foreach (dynamic item in participante)
                            {
                                participanteModelo.cedula_participante = item.cedula;

                            }
                            //participanteModelo.codigo_materia = codigo;
                            // Inserta la hora de tipo String y se formatea la misma hh(12 horas)
                            participanteModelo.hora_llegada = DateTime.Now.ToString("hh:mm");
                            participanteModelo.fecha = DateTime.Now.Date;

                            db.asistencia_participante.Add(participanteModelo);
                            db.SaveChanges();
                        }
                        else
                        {
                            // Busco el objeto deseado por su ID para su modificacion o insercion de la Salida. 
                            participanteModelo = db.asistencia_participante.Find(GetId);
                            // Inserta la hora de tipo String y se formatea la misma hh(12 horas)
                            participanteModelo.hora_salida = DateTime.Now.ToString("hh:mm");
                            db.Entry(participanteModelo).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                        break;

                    default:
                        Console.WriteLine($"Ha ocurrido un error!!! -- {respuesta.StatusCode} :(");
                        break;
                }
            }

        }

        public static async Task<bool> GetCedulaParticipante(string cedula)
        {

            var url = $"https://localhost:7225/api/participantes/{cedula}";

            using (var httpClient = new HttpClient())
            {

                var respuesta = await httpClient.GetAsync(url);



                // Condicion que comprueba el estado de la consulta al API

                switch (respuesta.StatusCode)
                {
                    // Si el estatus es ok/200 se procede a su uso
                    case System.Net.HttpStatusCode.OK:
                        var respuestaString = await respuesta.Content.ReadAsStringAsync();

                        // Convierto la respuesta del API en una lista de objetos Dinamico
                        var facilitador = JsonConvert.DeserializeObject<List<string>>(respuestaString);

                        {
                            foreach (dynamic item in facilitador)
                            {
                                string a = item.cedula;
                                if (cedula == a){ return true; }

                            }

                        }
                        break;

                    default:
                        Console.WriteLine($"Ha ocurrido un error!!! -- {respuesta.StatusCode} :(");
                        break;
                }

            }

            return false;

        }


    }
}
