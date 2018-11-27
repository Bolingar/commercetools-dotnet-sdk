﻿using System;
using System.Collections.Generic;
using System.Text;

namespace commercetools.Sdk.Domain.Categories
{
    public class SetAssetKeyUpdateAction : UpdateAction<Category>
    {
        public string Action => "setAssetKey";
        public string AssetId { get; set; }
        public string AssetKey { get; set; }
    }
}
