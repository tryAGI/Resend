
#nullable enable

namespace Resend
{
    /// <summary>
    /// The API key can have full access to Resend’s API or be only restricted to send emails. * full_access - Can create, delete, get, and update any resource. * sending_access - Can only send emails.
    /// </summary>
    public enum CreateApiKeyRequestPermission
    {
        /// <summary>
        /// 
        /// </summary>
        FullAccess,
        /// <summary>
        /// 
        /// </summary>
        SendingAccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateApiKeyRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyRequestPermission value)
        {
            return value switch
            {
                CreateApiKeyRequestPermission.FullAccess => "full_access",
                CreateApiKeyRequestPermission.SendingAccess => "sending_access",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "full_access" => CreateApiKeyRequestPermission.FullAccess,
                "sending_access" => CreateApiKeyRequestPermission.SendingAccess,
                _ => null,
            };
        }
    }
}