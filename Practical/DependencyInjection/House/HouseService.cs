using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HouseService
    {
        Electricity,
        Water,
        Internet,
        Cleaning,
        Sanitation
    }
}
