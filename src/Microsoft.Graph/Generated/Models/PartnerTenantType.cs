using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PartnerTenantType {
        [EnumMember(Value = "microsoftSupport")]
        MicrosoftSupport,
        [EnumMember(Value = "syndicatePartner")]
        SyndicatePartner,
        [EnumMember(Value = "breadthPartner")]
        BreadthPartner,
        [EnumMember(Value = "breadthPartnerDelegatedAdmin")]
        BreadthPartnerDelegatedAdmin,
        [EnumMember(Value = "resellerPartnerDelegatedAdmin")]
        ResellerPartnerDelegatedAdmin,
        [EnumMember(Value = "valueAddedResellerPartnerDelegatedAdmin")]
        ValueAddedResellerPartnerDelegatedAdmin,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
