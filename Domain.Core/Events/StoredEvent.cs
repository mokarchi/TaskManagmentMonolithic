﻿using System;

namespace TaskManagment.Domain.Core.Events
{
    public class StoredEvent
    {
        public StoredEvent()
        {
        }

        public string Type { get; set; }
        public object Requerst { get; set; }
        public object Response { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
