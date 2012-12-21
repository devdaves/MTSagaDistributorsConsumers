﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messages.Interfaces;

namespace Messages
{
    public class WorkingStartMessage : IWorkingStartMessage
    {
        public Guid CorrelationId { get; set; }
        public int UserId { get; set; }
    }
}
