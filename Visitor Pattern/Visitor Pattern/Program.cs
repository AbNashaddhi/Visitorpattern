using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailVisitor = new EmailVisitor();
            var textVisitor = new TextVisitor();
            var webside = new Webvisitor();
            var notificationSender1 = new InvoiceMarktingSender();
            notificationSender1.Accept(emailVisitor);
            notificationSender1.Accept(textVisitor);
            notificationSender1.Accept(webside);
            notificationSender1.Send("invoice");

            var notificationSender2 = new MarktingNotificationSender();
            notificationSender2.Send("Markting");
            notificationSender2.Accept(emailVisitor);
            notificationSender2.Accept(textVisitor);
        }
    }
}
