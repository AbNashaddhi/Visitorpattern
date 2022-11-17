﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    interface INotificationSender
    {
        void send(string Message);
        void Accept(IVisitor vistor);
    }
}