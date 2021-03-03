using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SmsMessageCommand: IMessageCommand
    {
        private Message oMessage;

        public SmsMessageCommand(Message oMessage)
        {
            this.oMessage = oMessage;
        }
        public void DoAction()
        { 
            oMessage.SmsMessage();
        } 
    }
}
