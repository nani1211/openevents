﻿using System;
using System.Collections.Generic;
using System.Linq;
using OpenEvents.Backend.Orders.Common;

namespace OpenEvents.Backend.Orders.Model
{
    public class OrderDocumentDTO
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public OrderDocumentType Type { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}