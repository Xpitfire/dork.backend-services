using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Dork.Models
{
    public class EntityResponse<T>
    {
        public T Entity { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }

}
