using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class EmailMessageCommand: IMessageCommand
    {
        private Message oMessage;

        public EmailMessageCommand(Message oMessage)
        {
            this.oMessage = oMessage;
        }

        public void DoAction()
        {
            oMessage.EmailMessage();
        }

    }
}
