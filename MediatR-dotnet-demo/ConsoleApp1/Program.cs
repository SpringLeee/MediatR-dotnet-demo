using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            message.CustomMessage = "Welcome by Email";
            EmailMessageCommand emailMessageCommand = new EmailMessageCommand(message);

            Message message2 = new Message();
            message2.CustomMessage = "Welcome by SMS";
            SmsMessageCommand smsMessageCommand = new SmsMessageCommand(message2);

            Broker broker = new Broker();
            broker.SendMessage(emailMessageCommand);
            broker.SendMessage(smsMessageCommand);
            Console.ReadKey();
        }
    }
}
