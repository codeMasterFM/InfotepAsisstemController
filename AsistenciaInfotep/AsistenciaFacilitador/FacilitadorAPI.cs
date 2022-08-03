using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace infotepAssistControl.AsistenciaFacilitador
{
	public class FacilitadorAPI
	{

       public static async Task MyApi(string codigo, string cedula)
        {
            // Instancia del FacilitadorModelo de la base de datos
            infotedbEntities db = new infotedbEntities();

            // Instacia del Objeto Facilitador para poder acceder a sus atributos y asignarselos
            asistencia_facilitador facilitadorFacilitadorModelo = new asistencia_facilitador();

            List<asistencia_facilitador> facilitadorLista = new List<asistencia_facilitador>();

            // Consulto la API pasandole los parametros de codigo y cedula.
            // Me retorna el maestro asignado a una materia junto con su codigo y cedula
            var url = $"http://localhost/ApiAssisControlInfotep/Api-Cursos/public/api/consultaMaestroMateria/{codigo}/{cedula}";
            using (var httpClient = new HttpClient())
            {

                var respuesta = await httpClient.GetAsync(url);

                // Almaceno la fecha de hoy, debe de estar en una variable
                var fechaHoy = DateTime.Now.Date;

                // Me retorna una lista de objetos que conicidan con la fecha y la cedula ingresada.
                facilitadorLista = db.asistencia_facilitador.Where(x => DbFunctions.TruncateTime(x.fecha) == fechaHoy
                                    && x.cedula_facilitador == cedula).ToList();

                int GetId = 0;

                // Me retorna el ultimo ID del facilitador.
                foreach (var item in facilitadorLista)
                {
                    GetId = item.id_asis_facilitador;

                }

                // Condicion que comprueba el estado de la consulta al API

                switch (respuesta.StatusCode)
                {
                    // Si el estatus es ok/200 se procede a su uso
                    case System.Net.HttpStatusCode.OK:
                        var respuestaString = await respuesta.Content.ReadAsStringAsync();

                        // Convierto la respuesta del API en una lista de objetos Dinamico
                        var facilitador = JsonConvert.DeserializeObject<List<dynamic>>(respuestaString);

                        // Condicion para saber si existe un registro del facilitador para poder registrar su entrada o salida
                        if (GetId == 0)
                        {
                            foreach (dynamic item in facilitador)
                            {
                                facilitadorFacilitadorModelo.cedula_facilitador = item.cedula;

                            }
                            facilitadorFacilitadorModelo.codigo_materia = codigo;
                            // Inserta la hora de tipo String y se formatea la misma hh(12 horas)
                            facilitadorFacilitadorModelo.hora_llegada = DateTime.Now.ToString("hh:mm");
                            facilitadorFacilitadorModelo.fecha = DateTime.Now.Date;

                            db.asistencia_facilitador.Add(facilitadorFacilitadorModelo);
                            db.SaveChanges();
                          
                        }
                        else
                        {
                            // Busco el objeto deseado por su ID para su modificacion o insercion de la Salida. 
                            facilitadorFacilitadorModelo = db.asistencia_facilitador.Find(GetId);
                            // Inserta la hora de tipo String y se formatea la misma hh(12 horas)
                            facilitadorFacilitadorModelo.hora_salida = DateTime.Now.ToString("hh:mm");
                            db.Entry(facilitadorFacilitadorModelo).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                        break;

                    default:
                        Console.WriteLine($"Ha ocurrido un error!!! -- {respuesta.StatusCode} :(");
                        break;
                }
               
            }

        }

        //por si el codigo es incorrecto o no se encuentra en la base de datos
        public static async Task<bool> GetMateria(string codigo) {

            var url = $"http://localhost/ApiAssisControlInfotep/Api-Cursos/public/api/materias/";
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
                        var facilitador = JsonConvert.DeserializeObject<List<dynamic>>(respuestaString);

                        {
                            foreach (dynamic item in facilitador)
                            {
                                string a = item.codigo;
                                if (codigo == a)
                                {
                                    return true;                                    

                                }

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

        public static async Task<bool> GetFacilitador(string cedula)
        {

            var url = $"http://localhost/ApiAssisControlInfotep/Api-Cursos/public/api/maestro/";
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
                        var facilitador = JsonConvert.DeserializeObject<List<dynamic>>(respuestaString);

                        {
                            foreach (dynamic item in facilitador)
                            {
                                string a = item.cedula;
                                if (cedula == a)
                                {
                                    return true;

                                }

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
