using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.AvailableMethods;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace infotepAssistControl.Notificaciones.controller
{
    public class TelgramController
    {
        string consulta = "";
        static ITelegramBot TelegramBot;
        string url = "http://localhost/ApiAssisControlInfotep/Api-Cursos/public/api/participanteCurso";

        public async void apiTelegram(string cedula, string fecha_de_entrada)
        {
            //var me = TelegramBot = new BotClient("5310501794:AAGElUOwqwjI9priOeIBGJ1wUIPMy7RpVPk");
            var bot = new BotClient("5310501794:AAGElUOwqwjI9priOeIBGJ1wUIPMy7RpVPk");


            Notificaciones.controller.TelgramController telgram = new Notificaciones.controller.TelgramController();
            string respuestas = await telgram.GetHttp();
            List<Notificaciones.model.StudianteController> studiantes = JsonConvert.DeserializeObject<List<Notificaciones.model.StudianteController>>(respuestas);

            foreach (var item in studiantes.Where(x => x.cedula == cedula))
            {
                try
                {



                    bot.SendMessage("1563754867"/*messege.Chat.Id*/, item.nombre);
                    bot.SendMessage("1563754867"/*messege.Chat.Id*/, item.apellido);
                    bot.SendMessage("1563754867"/*messege.Chat.Id*/, item.cedula);
                    bot.SendMessage("1563754867"/*messege.Chat.Id*/, item.curso);
                    bot.SendMessage("1563754867"/*messege.Chat.Id*/, fecha_de_entrada);
                    break;
                }

                catch (Exception)
                {

                   
                }
            }


            // bot.SendMessage("2092130251"/*messege.Chat.Id*/, "le da ansiedad");
            // bot.SendMessage("1016508099"/*messege.Chat.Id*/, "le da ansiedad");




        }
            public async Task<string> GetHttp()
            {


                WebRequest webRequest = WebRequest.Create(url);
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());

                //consulta = streamReader.ReadToEnd();
                //Console.WriteLine(consulta);

                return await streamReader.ReadLineAsync();
            }


        
    }
}
