using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class MessengerManager
    {
        readonly List<string> chainOfResponsibility = new List<string>(){ "NotificationMessenger", "SmsMessenger", "MailMessenger" };
        readonly List<IMessenger> messengers = new List<IMessenger>();

        public MessengerManager()
        {
            Prepare();
        }

        private void Prepare()
        {
            AddMessengers();
            ChainMessengers();
        }

        private void ChainMessengers()
        {
            for (int i = 0; i < messengers.Count - 1; i++)
            {
                messengers[i].Next = messengers[i + 1];
            }
        }

        private void AddMessengers()
        {
            for (int i = 0; i < chainOfResponsibility.Count; ++i)
            {
                IMessenger messenger = (IMessenger)GetMessenger(chainOfResponsibility[i]);
                messengers.Add(messenger);
            }
        }

        private object GetMessenger(string typeName)
        {
            var namespaceName = "ChainOfResponsibility";
            var type = Type.GetType(namespaceName + "." + typeName, true);
            var instance = Activator.CreateInstance(type);
            return instance;
        }

        public void Forward(string message)
        {
            messengers.FirstOrDefault().Forward(message);
        }
    }

    abstract class IMessenger
    {
        // template method pattern
        public void Forward(string message)
        {
            try
            {
                ForwardMessage(message);
            }
            catch
            {
                if (Next != null)
                    Next.Forward(message);

            }
        }

        public abstract void ForwardMessage(string message);
        public IMessenger Next { get; set; }
    }

    class NotificationMessenger : IMessenger
    {
        public override void ForwardMessage(string message)
        {
            throw new NullReferenceException();
            Console.WriteLine($"The message \"{message}\" is transmitted via Notification");
        }
    }

    class SmsMessenger : IMessenger
    {
        public override void ForwardMessage(string message)
        {
            throw new NullReferenceException();
            Console.WriteLine($"The message \"{message}\" is transmitted via SMS");

        }
    }

    class MailMessenger : IMessenger
    {
        public override void ForwardMessage(string message)
        {
            Console.WriteLine($"The message \"{message}\" is transmitted via E-Mail");
        }
    }
}
