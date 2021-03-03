using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Broker
    {
        public void SendMessage(IMessageCommand command)
        {
            command.DoAction();
        }

    }
}
