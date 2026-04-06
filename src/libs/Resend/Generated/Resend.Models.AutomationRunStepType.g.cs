
#nullable enable

namespace Resend
{
    /// <summary>
    /// The type of automation step.
    /// </summary>
    public enum AutomationRunStepType
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
    public static class AutomationRunStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRunStepType value)
        {
            return value switch
            {
                AutomationRunStepType.AddToSegment => "add_to_segment",
                AutomationRunStepType.Condition => "condition",
                AutomationRunStepType.ContactDelete => "contact_delete",
                AutomationRunStepType.ContactUpdate => "contact_update",
                AutomationRunStepType.Delay => "delay",
                AutomationRunStepType.SendEmail => "send_email",
                AutomationRunStepType.Trigger => "trigger",
                AutomationRunStepType.WaitForEvent => "wait_for_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRunStepType? ToEnum(string value)
        {
            return value switch
            {
                "add_to_segment" => AutomationRunStepType.AddToSegment,
                "condition" => AutomationRunStepType.Condition,
                "contact_delete" => AutomationRunStepType.ContactDelete,
                "contact_update" => AutomationRunStepType.ContactUpdate,
                "delay" => AutomationRunStepType.Delay,
                "send_email" => AutomationRunStepType.SendEmail,
                "trigger" => AutomationRunStepType.Trigger,
                "wait_for_event" => AutomationRunStepType.WaitForEvent,
                _ => null,
            };
        }
    }
}