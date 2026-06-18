
#nullable enable

namespace Resend
{
    /// <summary>
    /// The region where emails will be sent from. Possible values are us-east-1 | eu-west-1 | sa-east-1 | ap-northeast-1<br/>
    /// Default Value: us-east-1
    /// </summary>
    public enum CreateDomainClaimRequestRegion
    {
        /// <summary>
        /// 
        /// </summary>
        ApNortheast1,
        /// <summary>
        /// 
        /// </summary>
        EuWest1,
        /// <summary>
        /// 
        /// </summary>
        SaEast1,
        /// <summary>
        /// 
        /// </summary>
        UsEast1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDomainClaimRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDomainClaimRequestRegion value)
        {
            return value switch
            {
                CreateDomainClaimRequestRegion.ApNortheast1 => "ap-northeast-1",
                CreateDomainClaimRequestRegion.EuWest1 => "eu-west-1",
                CreateDomainClaimRequestRegion.SaEast1 => "sa-east-1",
                CreateDomainClaimRequestRegion.UsEast1 => "us-east-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDomainClaimRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => CreateDomainClaimRequestRegion.ApNortheast1,
                "eu-west-1" => CreateDomainClaimRequestRegion.EuWest1,
                "sa-east-1" => CreateDomainClaimRequestRegion.SaEast1,
                "us-east-1" => CreateDomainClaimRequestRegion.UsEast1,
                _ => null,
            };
        }
    }
}