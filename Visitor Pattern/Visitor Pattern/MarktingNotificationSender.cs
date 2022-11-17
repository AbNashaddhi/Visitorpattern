using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    class MarktingNotificationSender : INotificationSender
    {
        public void Accept(IVisitor vistor)
        {
            vistor.Visitor(this);
        }

        public void send(string Message)
        {
            Console.WriteLine($"Notification sent:{ Message}");
        }


    }
}
