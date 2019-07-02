using System;

namespace LukaszDrozdzLab5.Models
{
    public class ErrorViewModel
    {
        /// <summary>
        /// Request ID
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Auto-generated method
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}