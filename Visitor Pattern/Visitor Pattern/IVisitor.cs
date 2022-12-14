using System;

namespace Visitor_Pattern
{
    internal interface IVisitor
    {
        void Visitor(INotificationSender Sender);
    }
    internal class EmailVisitor : IVisitor
    {
        public void Visitor(INotificationSender sender)
        {
            Console.WriteLine("Setup Email");
        }
    }
    internal class TextVisitor : IVisitor
    {
        public void Visitor(INotificationSender sender)
        {
            Console.WriteLine("Setup Text");
        }
    }
    internal class Webvisitor : IVisitor
    {
        public void Visitor(INotificationSender sender)
        {
            Console.WriteLine("Web side visitor");
        }
    }
}