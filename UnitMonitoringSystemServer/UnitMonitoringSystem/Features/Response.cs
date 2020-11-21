using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitMonitoringSystem.Api.Features
{
    public class Response
    {
        public object Data { get; set; }
        public bool HasError { get; set; }

        public Response(object data, bool hasError = false)
        {
            Data = data;
            HasError = hasError;
        }
    }
}
