using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string message = null, string deails = null) : base(statusCode, message)
        {
            Details = Details;
        }

        public int Details { get; set; }
    }
}