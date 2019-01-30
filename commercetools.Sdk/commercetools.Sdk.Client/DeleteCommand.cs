﻿using commercetools.Sdk.Domain;

namespace commercetools.Sdk.Client
{
    public abstract class DeleteCommand<T> : Command<T>
    {
        public string ParameterKey { get; protected set; }

        public object ParameterValue { get; protected set; }

        public int Version { get; protected set; }

        public bool? DataErasure { get; set; }

        public override System.Type ResourceType => typeof(T);
    }
}