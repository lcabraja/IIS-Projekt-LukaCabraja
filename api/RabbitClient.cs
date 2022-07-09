using model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace api
{
    public static class RabbitClient
    {
        static readonly System.Xml.Serialization.XmlSerializer userSerializer = new(new User().GetType());

        public static void SendMessage(IModel model, object message)
        {
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            model.BasicPublish(exchange: "", routingKey: "users", body: body);
        }
    }
}
