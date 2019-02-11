using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PingPongProject.Models
{
    // This is a class which can show customized error messages using different properties
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Description { get; set; }
    }
}