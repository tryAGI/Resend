
#nullable enable

namespace Resend
{
    /// <summary>
    /// AWS region where the domain is configured.
    /// </summary>
    public enum DomainEventDataRegion
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
    public static class DomainEventDataRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainEventDataRegion value)
        {
            return value switch
            {
                DomainEventDataRegion.ApNortheast1 => "ap-northeast-1",
                DomainEventDataRegion.EuWest1 => "eu-west-1",
                DomainEventDataRegion.SaEast1 => "sa-east-1",
                DomainEventDataRegion.UsEast1 => "us-east-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainEventDataRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => DomainEventDataRegion.ApNortheast1,
                "eu-west-1" => DomainEventDataRegion.EuWest1,
                "sa-east-1" => DomainEventDataRegion.SaEast1,
                "us-east-1" => DomainEventDataRegion.UsEast1,
                _ => null,
            };
        }
    }
}