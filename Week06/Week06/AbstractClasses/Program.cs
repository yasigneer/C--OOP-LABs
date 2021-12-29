using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            MailSender mailSender = new MailSender();

            SmsSender smsSender = new SmsSender();

            SendMessage(mailSender, "asecer", "123");

            SendMessage(smsSender, "asecer", "123");

            SendMessage(new WhatsupSender(), "asecer", "123");

            //ILogger logger = new ILogger();  interfaces cannot be created as an object, inherited by interfaces, implemented by classes
            //MessageSender messageSender = new MessageSender();  abstract clas cannot be created as an object, only can be inherited

        }

        static void SendMessage(MessageSender ms, string uName, string password)
        {
            if (ms.Login(uName, password))
            {
                ms.Send();
            }
        }
    }

    #region examle 1
    interface ILogger
    {
        void WriteLog();
    }
    abstract class SecurityCheck
    {
        public abstract bool Login(string uName, string password);
    }

    abstract class MessageSender : SecurityCheck
    {
        public abstract void Send();

        public void DoAnyJob()
        {
            Console.WriteLine("DoAnyJob");
        }

    }


    class MailSender : MessageSender //implementing single abstract class
    {
        //public sealed override bool Login(string uName, string password)
        //{
        //    Console.WriteLine("Login success for email");

        //    return true;
        //}

        public  override bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for email");

            return true;
        }

        public override void Send()
        {
            Console.WriteLine("Email sent successfully");
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }

    class test:MailSender
    {
        public test()
        {
            
        }

        public override  bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for email");

            return true;
        }

    }
    class SmsSender : MessageSender
    {
        public override bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for Sms");
            return true;
        }

        public override void Send()
        {
            Console.WriteLine("Sms sent successfully");
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }

    class WhatsupSender : MessageSender, ILogger
    {
        public override bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for Whatsup");
            return true;
        }

        public override void Send()
        {
            Console.WriteLine("Whatsup message sent successfully");
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

}
