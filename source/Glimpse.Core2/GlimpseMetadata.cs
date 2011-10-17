using System;
using System.Collections.Generic;

namespace Glimpse.Core2
{
    public class GlimpseMetadata
    {
        public GlimpseMetadata(Guid requestId, RequestMetadata requestMetadata, IDictionary<string, string> pluginData)
        {
            RequestId = requestId;
            RequestMetadata = requestMetadata;
            PluginData = pluginData;
            DateTime = DateTime.Now;
        }

        public Guid RequestId { get; set; }
        public DateTime DateTime { get; set; }
        public RequestMetadata RequestMetadata { get; set; }
        public IDictionary<string, string> PluginData { get; set; }
    }
}