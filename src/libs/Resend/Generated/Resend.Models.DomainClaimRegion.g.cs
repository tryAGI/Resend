
#nullable enable

namespace Resend
{
    /// <summary>
    /// The region where the claimed domain will send from.<br/>
    /// Example: us-east-1
    /// </summary>
    public enum DomainClaimRegion
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
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
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
    public static class DomainClaimRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainClaimRegion value)
        {
            return value switch
            {
                DomainClaimRegion.ApNortheast1 => "ap-northeast-1",
                DomainClaimRegion.EuWest1 => "eu-west-1",
                DomainClaimRegion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                DomainClaimRegion.SaEast1 => "sa-east-1",
                DomainClaimRegion.UsEast1 => "us-east-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainClaimRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => DomainClaimRegion.ApNortheast1,
                "eu-west-1" => DomainClaimRegion.EuWest1,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => DomainClaimRegion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "sa-east-1" => DomainClaimRegion.SaEast1,
                "us-east-1" => DomainClaimRegion.UsEast1,
                _ => null,
            };
        }
    }
}