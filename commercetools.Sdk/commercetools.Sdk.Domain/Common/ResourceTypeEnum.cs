﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace commercetools.Sdk.Domain
{
    public enum ResourceTypeId
    {
        [Description("asset")]
        Asset,
        [Description("category")]
        Category,
        [Description("channel")]
        Channel,
        [Description("customer")]
        Customer,
        [Description("customer-group")]
        CustomerGroup,
        [Description("cart-discount")]
        CartDiscount,
        [Description("discount-code")]
        DiscountCode,
        [Description("inventory-entry")]
        InventoryEntry,
        [Description("line-item")]
        LineItem,
        [Description("custom-line-item")]
        CustomLineItem,
        [Description("product-price")]
        ProductPrice,
        [Description("payment")]
        Payment,
        [Description("payment-interface-interaction")]
        PaymentInterfaceInteraction,
        [Description("shopping-list")]
        ShoppingList,
        [Description("shopping-list-text-line-item")]
        ShoppingListTextLineItem,
        [Description("review")]
        Review

    }
}
