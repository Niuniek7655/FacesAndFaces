namespace Messaging.Interfaces.Constants.Constants
{
    public class RabbitMqMassTransitConstants
    {
        public const string RabbitMquri = "rabbitmq://rabbitmq:5672";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterOrderServiceQueue = "register.order.command";
    }
}
