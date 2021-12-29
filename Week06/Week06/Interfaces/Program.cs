using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {


            //MailSender mailSender = new MailSender();

            //SmsSender smsSender = new SmsSender();

            //SendMessage(mailSender,"asecer", "123");

            //SendMessage(smsSender, "asecer", "123");

            //SendMessage(new WhatsupSender(), "asecer", "123");

            //abstract object                  concrete object
            IMathOperation mathOperation = new Math();
            var mathOperation1 = new Math();
            Math mathOperation2= new Math();
           

            ///IMathOperation math = new IMathOperation();


        }

        static void SendMessage(IMessageSender ms, string uName, string password)
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
    interface ISecurityCheck
    {
        bool Login(string uName, string password);
    }

    interface IMessageSender : ISecurityCheck //Interface inheritance
    {
        void Send();

    }


    class MailSender : IMessageSender, ILogger //implementing multi interfacess
    {
        public bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for email");
            return true;
        }

        public void Send()
        {
            Console.WriteLine("Email sent successfully");
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }

    class SmsSender : IMessageSender, ILogger
    {
        public bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for Sms");
            return true;
        }

        public void Send()
        {
            Console.WriteLine("Sms sent successfully");
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }

    class WhatsupSender : IMessageSender,ILogger
    {
        public bool Login(string uName, string password)
        {
            Console.WriteLine("Login success for Whatsup");
            return true;
        }

        public void Send()
        {
            Console.WriteLine("Whatsup message sent successfully");
        }

        public void WriteLog()
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region example 2

    interface IMathOperation
    {
        public double PI { get; } //readonly property
        double Sum(double a, double b);
        double Substract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    class Math : IMathOperation
    {
        public double PI { get =>3.14; }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }





    #endregion







}
