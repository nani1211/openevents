﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenEvents.Backend.Orders.Model
{
    public class CalculateOrderItemDTO
    {

        public string Sku { get; set; }

        public decimal Amount { get; set; }

    }
}