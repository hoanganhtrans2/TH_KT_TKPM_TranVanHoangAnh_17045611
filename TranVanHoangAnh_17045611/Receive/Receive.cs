using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.ActiveMQ;
using Apache.NMS;
using Apache.NMS.ActiveMQ.Commands;

namespace Receive
{
    class Receive
    {
        static void Main(string[] args)
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue destination = new ActiveMQQueue("HoangAnh");
            IMessageConsumer consumer = session.CreateConsumer(destination);
            consumer.Listener += Consumer_Listener;
            Console.ReadLine();
        }
        private static void Consumer_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;
                Console.WriteLine("receive:" + msg.Text);
               
            }
        }

    }
}
