#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmailFailedEventData : global::System.IEquatable<EmailFailedEventData>
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
        public global::Resend.EmailFailedEventDataVariant2? EmailFailedEventDataVariant2 { get; init; }
#else
        public global::Resend.EmailFailedEventDataVariant2? EmailFailedEventDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmailFailedEventDataVariant2))]
#endif
        public bool IsEmailFailedEventDataVariant2 => EmailFailedEventDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmailFailedEventDataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.EmailFailedEventDataVariant2? value)
        {
            value = EmailFailedEventDataVariant2;
            return IsEmailFailedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailFailedEventDataVariant2 PickEmailFailedEventDataVariant2() => IsEmailFailedEventDataVariant2
            ? EmailFailedEventDataVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmailFailedEventDataVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailFailedEventData(global::Resend.OutboundEmailEventData value) => new EmailFailedEventData((global::Resend.OutboundEmailEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.OutboundEmailEventData?(EmailFailedEventData @this) => @this.Outbound;

        /// <summary>
        /// 
        /// </summary>
        public EmailFailedEventData(global::Resend.OutboundEmailEventData? value)
        {
            Outbound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailFailedEventData FromOutbound(global::Resend.OutboundEmailEventData? value) => new EmailFailedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailFailedEventData(global::Resend.EmailFailedEventDataVariant2 value) => new EmailFailedEventData((global::Resend.EmailFailedEventDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.EmailFailedEventDataVariant2?(EmailFailedEventData @this) => @this.EmailFailedEventDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmailFailedEventData(global::Resend.EmailFailedEventDataVariant2? value)
        {
            EmailFailedEventDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailFailedEventData FromEmailFailedEventDataVariant2(global::Resend.EmailFailedEventDataVariant2? value) => new EmailFailedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public EmailFailedEventData(
            global::Resend.OutboundEmailEventData? outbound,
            global::Resend.EmailFailedEventDataVariant2? emailFailedEventDataVariant2
            )
        {
            Outbound = outbound;
            EmailFailedEventDataVariant2 = emailFailedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmailFailedEventDataVariant2 as object ??
            Outbound as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Outbound?.ToString() ??
            EmailFailedEventDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutbound && IsEmailFailedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Resend.OutboundEmailEventData, TResult>? outbound = null,
            global::System.Func<global::Resend.EmailFailedEventDataVariant2, TResult>? emailFailedEventDataVariant2 = null,
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
            else if (IsEmailFailedEventDataVariant2 && emailFailedEventDataVariant2 != null)
            {
                return emailFailedEventDataVariant2(EmailFailedEventDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,

            global::System.Action<global::Resend.EmailFailedEventDataVariant2>? emailFailedEventDataVariant2 = null,
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
            else if (IsEmailFailedEventDataVariant2)
            {
                emailFailedEventDataVariant2?.Invoke(EmailFailedEventDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,
            global::System.Action<global::Resend.EmailFailedEventDataVariant2>? emailFailedEventDataVariant2 = null,
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
            else if (IsEmailFailedEventDataVariant2)
            {
                emailFailedEventDataVariant2?.Invoke(EmailFailedEventDataVariant2!);
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
                EmailFailedEventDataVariant2,
                typeof(global::Resend.EmailFailedEventDataVariant2),
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
        public bool Equals(EmailFailedEventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Resend.OutboundEmailEventData?>.Default.Equals(Outbound, other.Outbound) &&
                global::System.Collections.Generic.EqualityComparer<global::Resend.EmailFailedEventDataVariant2?>.Default.Equals(EmailFailedEventDataVariant2, other.EmailFailedEventDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmailFailedEventData obj1, EmailFailedEventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmailFailedEventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmailFailedEventData obj1, EmailFailedEventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmailFailedEventData o && Equals(o);
        }
    }
}
