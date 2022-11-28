using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    class Program
    {
        public static List<IVisitor> visitors =
       new List<IVisitor>
           {
                new EmailVisitor(),
                new TextVisitor(),
                new Webvisitor()
           };
        public static void PrintOutputDetails(InvoiceMarktingSender marketSender, MarktingNotificationSender notification)
        {
           foreach (var visit in visitors)
            {
                if (marketSender!=null)
                {
                    marketSender.Accept(visit);
                   
                }
                else if (notification != null)
                {
                    notification.Accept(visit);
                }
            }
        }
    static void Main(string[] args)
        {
                
            var notificationSender1 = new InvoiceMarktingSender();
            PrintOutputDetails(notificationSender1,null);
            notificationSender1.Send("invoice");
            var notificationSender2 = new MarktingNotificationSender();
            PrintOutputDetails(null, notificationSender2);
            notificationSender2.Send("Markting");
            Console.ReadLine();
        }
    }
}
