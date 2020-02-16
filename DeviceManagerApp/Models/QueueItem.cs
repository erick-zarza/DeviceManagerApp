using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagerApp.Models
{
    public class QueueItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "queueItem")]
        public string QueueItemString { get; set; }

        [JsonProperty(PropertyName = "isStored")]
        public bool IsStored { get; set; }

        [JsonProperty(PropertyName = "_ts")]
        public long TimeStamp { get; set; }

    }
}
