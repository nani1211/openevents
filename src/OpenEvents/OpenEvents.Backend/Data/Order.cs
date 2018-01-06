﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenEvents.Backend.Data
{
    public class Order
    {

        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public Address BillingAddress { get; set; }

        public OrderCustomerData CustomerData { get; set; } = new OrderCustomerData();

        public OrderPaymentData PaymentData { get; set; } = new OrderPaymentData();

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public PriceData TotalPrice { get; set; } = new PriceData();

        public List<OrderDocument> OrderDocuments { get; set; } = new List<OrderDocument>();

        public DateTime? CanceledDate { get; set; }

        public string ReplacedByOrderId { get; set; }

        public List<ExtensionData> ExtensionData { get; set; } = new List<ExtensionData>();

    }
}