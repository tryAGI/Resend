
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of automation step.
    /// </summary>
    public enum AutomationStepResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        AddToSegment,
        /// <summary>
        /// 
        /// </summary>
        Condition,
        /// <summary>
        /// 
        /// </summary>
        ContactDelete,
        /// <summary>
        /// 
        /// </summary>
        ContactUpdate,
        /// <summary>
        /// 
        /// </summary>
        Delay,
        /// <summary>
        /// 
        /// </summary>
        SendEmail,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
        /// <summary>
        /// 
        /// </summary>
        WaitForEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationStepResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationStepResponseType value)
        {
            return value switch
            {
                AutomationStepResponseType.AddToSegment => "add_to_segment",
                AutomationStepResponseType.Condition => "condition",
                AutomationStepResponseType.ContactDelete => "contact_delete",
                AutomationStepResponseType.ContactUpdate => "contact_update",
                AutomationStepResponseType.Delay => "delay",
                AutomationStepResponseType.SendEmail => "send_email",
                AutomationStepResponseType.Trigger => "trigger",
                AutomationStepResponseType.WaitForEvent => "wait_for_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationStepResponseType? ToEnum(string value)
        {
            return value switch
            {
                "add_to_segment" => AutomationStepResponseType.AddToSegment,
                "condition" => AutomationStepResponseType.Condition,
                "contact_delete" => AutomationStepResponseType.ContactDelete,
                "contact_update" => AutomationStepResponseType.ContactUpdate,
                "delay" => AutomationStepResponseType.Delay,
                "send_email" => AutomationStepResponseType.SendEmail,
                "trigger" => AutomationStepResponseType.Trigger,
                "wait_for_event" => AutomationStepResponseType.WaitForEvent,
                _ => null,
            };
        }
    }
}