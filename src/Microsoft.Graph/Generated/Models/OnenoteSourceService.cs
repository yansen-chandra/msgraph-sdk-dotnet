using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum OnenoteSourceService {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "OneDrive")]
        OneDrive,
        [EnumMember(Value = "OneDriveForBusiness")]
        OneDriveForBusiness,
        [EnumMember(Value = "OnPremOneDriveForBusiness")]
        OnPremOneDriveForBusiness,
    }
}
