﻿using System.Collections.Generic;
using System.IO;

namespace EasyProxy.HttpServer
{
    public class HttpResponse
    {
        public HttpResponse()
        {
            Body = new MemoryStream();
            Headers = new Dictionary<string, string>();
        }
        public int StatusCode { get; set; } = 200;

        public string Version { get; set; } = "HTTP/1.1";

        public IDictionary<string, string> Headers { get; set; }

        public Stream Body { get; set; }

        public string ContentType { get; set; } = "text/html; charset=utf-8";
    }
}