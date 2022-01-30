using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_WebApi.Models
{
    public class ResponseModel<T>
    {
        public bool IsSuccess { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}