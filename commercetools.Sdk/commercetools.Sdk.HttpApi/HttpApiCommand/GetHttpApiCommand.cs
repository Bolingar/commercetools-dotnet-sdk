﻿namespace commercetools.Sdk.HttpApi
{
    using System.Net.Http;
    using commercetools.Sdk.Client;

    public class GetHttpApiCommand<T> : IHttpApiCommand<GetCommand<T>, T>
    {
        private readonly GetCommand<T> command;
        private readonly GetRequestMessageBuilder requestBuilder;

        public GetHttpApiCommand(GetCommand<T> command, IRequestMessageBuilderFactory requestMessageBuilderFactory)
        {
            this.command = command;
            this.requestBuilder = requestMessageBuilderFactory.GetRequestMessageBuilder<GetRequestMessageBuilder>();
        }

        public HttpRequestMessage HttpRequestMessage => this.requestBuilder.GetRequestMessage(this.command);
    }
}