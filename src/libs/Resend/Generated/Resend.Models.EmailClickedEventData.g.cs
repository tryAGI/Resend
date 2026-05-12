#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmailClickedEventData : global::System.IEquatable<EmailClickedEventData>
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
        public global::Resend.EmailClickedEventDataVariant2? EmailClickedEventDataVariant2 { get; init; }
#else
        public global::Resend.EmailClickedEventDataVariant2? EmailClickedEventDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmailClickedEventDataVariant2))]
#endif
        public bool IsEmailClickedEventDataVariant2 => EmailClickedEventDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmailClickedEventDataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.EmailClickedEventDataVariant2? value)
        {
            value = EmailClickedEventDataVariant2;
            return IsEmailClickedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailClickedEventDataVariant2 PickEmailClickedEventDataVariant2() => IsEmailClickedEventDataVariant2
            ? EmailClickedEventDataVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmailClickedEventDataVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailClickedEventData(global::Resend.OutboundEmailEventData value) => new EmailClickedEventData((global::Resend.OutboundEmailEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.OutboundEmailEventData?(EmailClickedEventData @this) => @this.Outbound;

        /// <summary>
        /// 
        /// </summary>
        public EmailClickedEventData(global::Resend.OutboundEmailEventData? value)
        {
            Outbound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailClickedEventData FromOutbound(global::Resend.OutboundEmailEventData? value) => new EmailClickedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailClickedEventData(global::Resend.EmailClickedEventDataVariant2 value) => new EmailClickedEventData((global::Resend.EmailClickedEventDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.EmailClickedEventDataVariant2?(EmailClickedEventData @this) => @this.EmailClickedEventDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmailClickedEventData(global::Resend.EmailClickedEventDataVariant2? value)
        {
            EmailClickedEventDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailClickedEventData FromEmailClickedEventDataVariant2(global::Resend.EmailClickedEventDataVariant2? value) => new EmailClickedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public EmailClickedEventData(
            global::Resend.OutboundEmailEventData? outbound,
            global::Resend.EmailClickedEventDataVariant2? emailClickedEventDataVariant2
            )
        {
            Outbound = outbound;
            EmailClickedEventDataVariant2 = emailClickedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmailClickedEventDataVariant2 as object ??
            Outbound as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Outbound?.ToString() ??
            EmailClickedEventDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutbound && IsEmailClickedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Resend.OutboundEmailEventData, TResult>? outbound = null,
            global::System.Func<global::Resend.EmailClickedEventDataVariant2, TResult>? emailClickedEventDataVariant2 = null,
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
            else if (IsEmailClickedEventDataVariant2 && emailClickedEventDataVariant2 != null)
            {
                return emailClickedEventDataVariant2(EmailClickedEventDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,

            global::System.Action<global::Resend.EmailClickedEventDataVariant2>? emailClickedEventDataVariant2 = null,
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
            else if (IsEmailClickedEventDataVariant2)
            {
                emailClickedEventDataVariant2?.Invoke(EmailClickedEventDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,
            global::System.Action<global::Resend.EmailClickedEventDataVariant2>? emailClickedEventDataVariant2 = null,
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
            else if (IsEmailClickedEventDataVariant2)
            {
                emailClickedEventDataVariant2?.Invoke(EmailClickedEventDataVariant2!);
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
                EmailClickedEventDataVariant2,
                typeof(global::Resend.EmailClickedEventDataVariant2),
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
        public bool Equals(EmailClickedEventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Resend.OutboundEmailEventData?>.Default.Equals(Outbound, other.Outbound) &&
                global::System.Collections.Generic.EqualityComparer<global::Resend.EmailClickedEventDataVariant2?>.Default.Equals(EmailClickedEventDataVariant2, other.EmailClickedEventDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmailClickedEventData obj1, EmailClickedEventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmailClickedEventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmailClickedEventData obj1, EmailClickedEventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmailClickedEventData o && Equals(o);
        }
    }
}
