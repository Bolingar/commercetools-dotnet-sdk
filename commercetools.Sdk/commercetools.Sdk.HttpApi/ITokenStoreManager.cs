﻿using commercetools.Sdk.HttpApi.Domain;

namespace commercetools.Sdk.HttpApi
{
    public interface ITokenStoreManager
    {
        Token Token { get; set; }
    }
}