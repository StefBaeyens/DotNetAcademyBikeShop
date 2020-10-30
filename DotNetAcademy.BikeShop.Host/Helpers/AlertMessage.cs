using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAcademy.BikeShop.Host.Helpers
{
    [Serializable]
    public enum AlertMessageType
    {
        Error,
        Warning,
        Success
    }

    [Serializable]
    public class AlertMessage
    {
        public string BootstrapClass =>
                Type switch
                {
                    AlertMessageType.Success => "alert-success",
                    AlertMessageType.Warning => "alert-warning",
                    AlertMessageType.Error => "alert-danger",
                    _ => "alert-primary"
                };

        public AlertMessageType Type { get; private set; }

        public string Message { get; private set; }

        public bool RawHtml { get; private set; }

        public AlertMessage(AlertMessageType type, string message, bool raw = false)
        {
            Type = type;
            Message = message;
            RawHtml = raw;
        }
    }
}
