﻿using System;
using System.Collections.Generic;
using System.Text;
using commercetools.Sdk.Domain.Carts;

namespace commercetools.Sdk.Domain.Orders
{
    [Endpoint("orders")]
    public class Order
    {
        public string Id { get; set; }
        public int Version { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string AnonymousId { get; set; }
        public List<LineItem> LineItems { get; set; }
        public List<CustomLineItem> CustomLineItems { get; set; }
        public Money TotalPrice { get; set; }
        public TaxedPrice TaxedPrice { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public TaxMode TaxMode { get; set; }
        public RoundingMode TaxRoundingMode { get; set; }
        public TaxCalculationMode TaxCalculationMode { get; set; }
        public Reference<CustomerGroup> CustomerGroup { get; set; }
        public string Country { get; set; }
        public OrderState OrderState { get; set; }
        public Reference<State> State { get; set; }
        public ShipmentState ShipmentState { get; set; }
        public PaymentState PaymentState { get; set; }
        public ShippingInfo ShippingInfo { get; set; }
        public SyncInfo SyncInfo { get; set; }
        public ReturnInfo ReturnInfo { get; set; }
        public List<DiscountCodeInfo> DiscountCodes { get; set; }
        public List<Reference<CartDiscount>> RefusedGifts { get; set; }
        public int LastMessageSequenceNumber { get; set; }
        public Reference<Cart> Cart { get; set; }
        public CustomFields Custom { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
        public string Locale { get; set; }
        public InventoryMode InventoryMode { get; set; }
        public IShippingRateInput ShippingRateInput { get; set; }
        public CartOrigin Origin { get; set; }
        public List<Address> ItemShippingAddresses { get; set; }
    }
}
