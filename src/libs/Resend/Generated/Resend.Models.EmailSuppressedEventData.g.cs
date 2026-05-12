#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmailSuppressedEventData : global::System.IEquatable<EmailSuppressedEventData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Resend.OutboundEmailEventData? Outbound { get; init; }
#else
        public global::Resend.OutboundEmailEventData? Outbound { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Outbound))]
#endif
        public bool IsOutbound => Outbound != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutbound(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.OutboundEmailEventData? value)
        {
            value = Outbound;
            return IsOutbound;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.OutboundEmailEventData PickOutbound() => IsOutbound
            ? Outbound!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Outbound' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Resend.EmailSuppressedEventDataVariant2? EmailSuppressedEventDataVariant2 { get; init; }
#else
        public global::Resend.EmailSuppressedEventDataVariant2? EmailSuppressedEventDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmailSuppressedEventDataVariant2))]
#endif
        public bool IsEmailSuppressedEventDataVariant2 => EmailSuppressedEventDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmailSuppressedEventDataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.EmailSuppressedEventDataVariant2? value)
        {
            value = EmailSuppressedEventDataVariant2;
            return IsEmailSuppressedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailSuppressedEventDataVariant2 PickEmailSuppressedEventDataVariant2() => IsEmailSuppressedEventDataVariant2
            ? EmailSuppressedEventDataVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmailSuppressedEventDataVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailSuppressedEventData(global::Resend.OutboundEmailEventData value) => new EmailSuppressedEventData((global::Resend.OutboundEmailEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.OutboundEmailEventData?(EmailSuppressedEventData @this) => @this.Outbound;

        /// <summary>
        /// 
        /// </summary>
        public EmailSuppressedEventData(global::Resend.OutboundEmailEventData? value)
        {
            Outbound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailSuppressedEventData FromOutbound(global::Resend.OutboundEmailEventData? value) => new EmailSuppressedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailSuppressedEventData(global::Resend.EmailSuppressedEventDataVariant2 value) => new EmailSuppressedEventData((global::Resend.EmailSuppressedEventDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.EmailSuppressedEventDataVariant2?(EmailSuppressedEventData @this) => @this.EmailSuppressedEventDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmailSuppressedEventData(global::Resend.EmailSuppressedEventDataVariant2? value)
        {
            EmailSuppressedEventDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailSuppressedEventData FromEmailSuppressedEventDataVariant2(global::Resend.EmailSuppressedEventDataVariant2? value) => new EmailSuppressedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public EmailSuppressedEventData(
            global::Resend.OutboundEmailEventData? outbound,
            global::Resend.EmailSuppressedEventDataVariant2? emailSuppressedEventDataVariant2
            )
        {
            Outbound = outbound;
            EmailSuppressedEventDataVariant2 = emailSuppressedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmailSuppressedEventDataVariant2 as object ??
            Outbound as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Outbound?.ToString() ??
            EmailSuppressedEventDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutbound && IsEmailSuppressedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Resend.OutboundEmailEventData, TResult>? outbound = null,
            global::System.Func<global::Resend.EmailSuppressedEventDataVariant2, TResult>? emailSuppressedEventDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutbound && outbound != null)
            {
                return outbound(Outbound!);
            }
            else if (IsEmailSuppressedEventDataVariant2 && emailSuppressedEventDataVariant2 != null)
            {
                return emailSuppressedEventDataVariant2(EmailSuppressedEventDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,

            global::System.Action<global::Resend.EmailSuppressedEventDataVariant2>? emailSuppressedEventDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutbound)
            {
                outbound?.Invoke(Outbound!);
            }
            else if (IsEmailSuppressedEventDataVariant2)
            {
                emailSuppressedEventDataVariant2?.Invoke(EmailSuppressedEventDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,
            global::System.Action<global::Resend.EmailSuppressedEventDataVariant2>? emailSuppressedEventDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutbound)
            {
                outbound?.Invoke(Outbound!);
            }
            else if (IsEmailSuppressedEventDataVariant2)
            {
                emailSuppressedEventDataVariant2?.Invoke(EmailSuppressedEventDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Outbound,
                typeof(global::Resend.OutboundEmailEventData),
                EmailSuppressedEventDataVariant2,
                typeof(global::Resend.EmailSuppressedEventDataVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EmailSuppressedEventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Resend.OutboundEmailEventData?>.Default.Equals(Outbound, other.Outbound) &&
                global::System.Collections.Generic.EqualityComparer<global::Resend.EmailSuppressedEventDataVariant2?>.Default.Equals(EmailSuppressedEventDataVariant2, other.EmailSuppressedEventDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmailSuppressedEventData obj1, EmailSuppressedEventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmailSuppressedEventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmailSuppressedEventData obj1, EmailSuppressedEventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmailSuppressedEventData o && Equals(o);
        }
    }
}
