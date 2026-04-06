
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of automation step.
    /// </summary>
    public enum AutomationStepType
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
    public static class AutomationStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationStepType value)
        {
            return value switch
            {
                AutomationStepType.AddToSegment => "add_to_segment",
                AutomationStepType.Condition => "condition",
                AutomationStepType.ContactDelete => "contact_delete",
                AutomationStepType.ContactUpdate => "contact_update",
                AutomationStepType.Delay => "delay",
                AutomationStepType.SendEmail => "send_email",
                AutomationStepType.Trigger => "trigger",
                AutomationStepType.WaitForEvent => "wait_for_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationStepType? ToEnum(string value)
        {
            return value switch
            {
                "add_to_segment" => AutomationStepType.AddToSegment,
                "condition" => AutomationStepType.Condition,
                "contact_delete" => AutomationStepType.ContactDelete,
                "contact_update" => AutomationStepType.ContactUpdate,
                "delay" => AutomationStepType.Delay,
                "send_email" => AutomationStepType.SendEmail,
                "trigger" => AutomationStepType.Trigger,
                "wait_for_event" => AutomationStepType.WaitForEvent,
                _ => null,
            };
        }
    }
}