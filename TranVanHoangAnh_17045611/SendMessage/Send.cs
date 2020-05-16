using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.ActiveMQ;
using Apache.NMS;
using Apache.NMS.ActiveMQ.Commands;

namespace SendMessage
{
    class Send
    {
        static void Main(string[] args)
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);            
            ActiveMQQueue destination = new ActiveMQQueue("HoangAnh");
            IMessageProducer producer = session.CreateProducer(destination);
            
            for(int i=0; i<1000; i++)
            {
                IMessage msg = new ActiveMQTextMessage("Hello "+i);
                producer.Send(msg);
            }
               
            session.Close();
            con.Close();
        }
    }
}
