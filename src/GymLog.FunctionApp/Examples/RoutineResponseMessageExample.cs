using System;

using GymLog.FunctionApp.Models;

using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Resolvers;

using Newtonsoft.Json.Serialization;

namespace GymLog.FunctionApp.Examples
{
    public class RoutineResponseMessageExample : OpenApiExample<RoutineResponseMessage>
    {
        public override IOpenApiExample<RoutineResponseMessage> Build(NamingStrategy namingStrategy = null)
        {
            this.Examples.Add(
                OpenApiExampleResolver.Resolve(
                    "shoulder",
                    new RoutineResponseMessage()
                    {
                        CorrelationId = Guid.Parse("36b5511c-f183-4eb3-b6b5-18cdf53417c9"),
                        SpanId = Guid.Parse("0458130f-d474-492f-b2c3-e385596f9d9b"),
                        EventId = Guid.Parse("93e8a2d5-dc0e-4603-897d-651eeb2969f8"),
                        RoutineId = Guid.Parse("15638065-9ab4-4041-83dd-e34870f7f6e5"),
                        Routine = RoutineType.Shoulder,
                    },
                    namingStrategy
                )
            );

            return this;
        }
    }
}