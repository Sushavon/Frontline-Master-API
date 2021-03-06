﻿using FrontlineMaster.Entity.Logging;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FrontlineMaster.API.Middlewares.Logging
{
    public class RequestHandler : DelegatingHandler
    {
        private readonly ICorrelationIdAccessor _correlationIdAccessor;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RequestHandler(ICorrelationIdAccessor correlationIdAccessor, IHttpContextAccessor httpContextAccessor)
        {
            this._correlationIdAccessor = correlationIdAccessor;
            this._httpContextAccessor = httpContextAccessor;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("CorrelationId", _correlationIdAccessor.GetCorrelationId());

            return base.SendAsync(request, cancellationToken);
        }
    }
}
