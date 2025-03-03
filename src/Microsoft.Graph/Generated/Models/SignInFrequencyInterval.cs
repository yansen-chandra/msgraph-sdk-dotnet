using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum SignInFrequencyInterval {
        [EnumMember(Value = "timeBased")]
        TimeBased,
        [EnumMember(Value = "everyTime")]
        EveryTime,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
