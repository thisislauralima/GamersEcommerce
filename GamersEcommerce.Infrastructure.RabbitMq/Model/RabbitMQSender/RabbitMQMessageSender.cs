﻿using GamersEcommerce.Infrastructure.RabbitMq;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace GamersEcommerce.Infrastructure.RabbitMq.Model.RabbitMQSender
{
    public class RabbitMQMessageSender : IRabbitMQMessageSender
    {
        string _hostName;
        string _password;
        string _userName;
        private IConnection _connection;

        public RabbitMQMessageSender()
        {
            _hostName = "localhost";
            _password = "guest";
            _userName = "guest";
        }

        public void SendMessage(BaseMessage message, string queueName)
        {
            var factory = new ConnectionFactory()
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password,
            };
            _connection = factory.CreateConnection();

            using var channel = _connection.CreateModel();

            channel.QueueDeclare(queue: queueName, false, false, false, arguments: null);

            byte[] body = GetMessageAsByteArray(message);

            channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
        }

        private byte[] GetMessageAsByteArray(BaseMessage message)
        {
            var options = new JsonSerializerOptions
            {
                // serializa as classes filhas
                WriteIndented = true,
            };
            // aqui adiciono a classe que irá herdar BaseMessage. Exemplo:
            //var json = JsonSerializer.Serialize<ClasseAqui>(message, options);
            var json = JsonSerializer.Serialize(message, options);
            var body = Encoding.UTF8.GetBytes(json);
            return body;
        }
    }
}
