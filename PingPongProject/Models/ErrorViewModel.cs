using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PingPongProject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Description { get; set; }
    }
}