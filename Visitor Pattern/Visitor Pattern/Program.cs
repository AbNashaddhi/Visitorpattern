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
            var emailvisitor = new EmailVisitor();
            var Textvisitor = new TextVisitor();
            var Webside = new Webvisitor();
            var Notificationsender1 = new InvoiceMarktingSender();
            Notificationsender1.Accept(emailvisitor);
            Notificationsender1.Accept(Textvisitor);
            Notificationsender1.Accept(Webside);
            Notificationsender1.send("invoice");

            var Notificationsender2 = new MarktingNotificationSender();
            Notificationsender2.send("Markting");
            Notificationsender2.Accept(emailvisitor);
            Notificationsender2.Accept(Textvisitor);
        }
    }
}
