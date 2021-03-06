using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker.Reactive.Pull.Api.Models
{
    public class OperationResult
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
    }

    public class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }
    }
}
