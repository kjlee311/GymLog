using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GymLog.FunctionApp.Traces
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventStatusType
    {
        Succeeded,

        Failed,
    }
}