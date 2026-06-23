using System;
using System.Collections.Generic;
using System.Text;

namespace JUNE_010626
{
 // Create a notification system with all functionalities
    interface INotification
    {
        void SendMessage();
        void ReceiveMessage();
    }

    class EmailNotification : INotification
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending email...");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving Email...");
        }
    }

    class SMSNotification : INotification
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending SMS..");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving SMS..");
        }
    }

    class WhatsAppNotification : INotification
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending Whatsapp Message..");
        }

        public void ReceiveMessage()
        {
            Console.WriteLine("Receiving Whatsapp Message..");
        }
    }
    internal class Q1_notificationSys
    {
        public static void Run()
        {
            INotification email = new EmailNotification();
            INotification sms = new SMSNotification();
            INotification whatsapp = new WhatsAppNotification();

            Console.WriteLine("EMAIL");
            email.SendMessage();
            email.ReceiveMessage();

            Console.WriteLine();

            Console.WriteLine("SMS");
            sms.SendMessage();
            sms.ReceiveMessage();

            Console.WriteLine();

            Console.WriteLine("WHATSAPP");
            whatsapp.SendMessage();
            whatsapp.ReceiveMessage();
        }
    }
}