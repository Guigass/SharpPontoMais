using System;
using System.Collections.Generic;
using System.Text;

namespace PontoMais.API.Models
{
    public class ApiResponse<T> where T : class
    {
        public bool IsSuccess { get; set; } = false;
        public string Status { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public T Object { get; set; }
    }
}
