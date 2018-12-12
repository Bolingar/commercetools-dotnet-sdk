﻿using commercetools.Sdk.Domain;
using commercetools.Sdk.Domain.Products.Attributes;

namespace commercetools.Sdk.Serialization
{
    public class MoneyAttributeMapper : MoneyConverter<Attribute, BaseMoney>, ICustomJsonMapper<Attribute>
    {
    }
}