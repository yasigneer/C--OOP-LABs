using System;
using System.Threading;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            messenger.MessageProcessCompleted += Messenger_MessageProcessCompleted;
            messenger.MessageProcessCompleted += Messenger_MessageProcessCompleted1;
            messenger.SendMessage();
            messenger.ReceiveMessage();
            messenger.MessageProcessCompleted -= Messenger_MessageProcessCompleted1;
        }

        private static void Messenger_MessageProcessCompleted1(object sender, MessengerEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void Messenger_MessageProcessCompleted(object sender, MessengerEventArgs e)
        {
            Console.WriteLine(e.MessageDirection+ ": Operation logged...");
        }
    }

    class Messenger
    {
        public delegate void MessageHandler(object sender, MessengerEventArgs e);

        public event MessageHandler MessageProcessCompleted;
        
        public void SendMessage()
        {
            Console.WriteLine("Message sent...");
            //...

            
            FireEvent("SendMessage() invoked");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Message received...");

            FireEvent("ReceiveMessage() invoked");
        }

        void FireEvent(string messageDirection)
        {
            if (MessageProcessCompleted!=null)
            {
                MessageProcessCompleted(this,new MessengerEventArgs(messageDirection));
            }
        }
    }

    public class MessengerEventArgs : EventArgs
    {
        public MessengerEventArgs(string messageDirection)
        {
            this.MessageDirection = messageDirection;
        }

        public string MessageDirection { get; private set; }
     
    }
}
