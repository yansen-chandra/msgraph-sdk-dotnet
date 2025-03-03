using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PlannerContainerType {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "roster")]
        Roster,
    }
}
