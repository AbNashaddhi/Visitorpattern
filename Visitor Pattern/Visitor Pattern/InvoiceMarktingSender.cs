using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    class InvoiceMarktingSender : INotificationSender
    {
        public void Accept(IVisitor user)
        {
            user.Visitor(this);

        }

        public void Send(string Message)
        {
            Console.WriteLine($"Notification sent:{ Message}");
        }

       
    }
}
