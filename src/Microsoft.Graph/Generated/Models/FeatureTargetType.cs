using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum FeatureTargetType {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "administrativeUnit")]
        AdministrativeUnit,
        [EnumMember(Value = "role")]
        Role,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
