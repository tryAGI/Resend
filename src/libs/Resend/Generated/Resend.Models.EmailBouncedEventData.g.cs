#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmailBouncedEventData : global::System.IEquatable<EmailBouncedEventData>
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
        public global::Resend.EmailBouncedEventDataVariant2? EmailBouncedEventDataVariant2 { get; init; }
#else
        public global::Resend.EmailBouncedEventDataVariant2? EmailBouncedEventDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmailBouncedEventDataVariant2))]
#endif
        public bool IsEmailBouncedEventDataVariant2 => EmailBouncedEventDataVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmailBouncedEventDataVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.EmailBouncedEventDataVariant2? value)
        {
            value = EmailBouncedEventDataVariant2;
            return IsEmailBouncedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.EmailBouncedEventDataVariant2 PickEmailBouncedEventDataVariant2() => IsEmailBouncedEventDataVariant2
            ? EmailBouncedEventDataVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmailBouncedEventDataVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailBouncedEventData(global::Resend.OutboundEmailEventData value) => new EmailBouncedEventData((global::Resend.OutboundEmailEventData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.OutboundEmailEventData?(EmailBouncedEventData @this) => @this.Outbound;

        /// <summary>
        /// 
        /// </summary>
        public EmailBouncedEventData(global::Resend.OutboundEmailEventData? value)
        {
            Outbound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailBouncedEventData FromOutbound(global::Resend.OutboundEmailEventData? value) => new EmailBouncedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmailBouncedEventData(global::Resend.EmailBouncedEventDataVariant2 value) => new EmailBouncedEventData((global::Resend.EmailBouncedEventDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.EmailBouncedEventDataVariant2?(EmailBouncedEventData @this) => @this.EmailBouncedEventDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmailBouncedEventData(global::Resend.EmailBouncedEventDataVariant2? value)
        {
            EmailBouncedEventDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmailBouncedEventData FromEmailBouncedEventDataVariant2(global::Resend.EmailBouncedEventDataVariant2? value) => new EmailBouncedEventData(value);

        /// <summary>
        /// 
        /// </summary>
        public EmailBouncedEventData(
            global::Resend.OutboundEmailEventData? outbound,
            global::Resend.EmailBouncedEventDataVariant2? emailBouncedEventDataVariant2
            )
        {
            Outbound = outbound;
            EmailBouncedEventDataVariant2 = emailBouncedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmailBouncedEventDataVariant2 as object ??
            Outbound as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Outbound?.ToString() ??
            EmailBouncedEventDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutbound && IsEmailBouncedEventDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Resend.OutboundEmailEventData, TResult>? outbound = null,
            global::System.Func<global::Resend.EmailBouncedEventDataVariant2, TResult>? emailBouncedEventDataVariant2 = null,
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
            else if (IsEmailBouncedEventDataVariant2 && emailBouncedEventDataVariant2 != null)
            {
                return emailBouncedEventDataVariant2(EmailBouncedEventDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,

            global::System.Action<global::Resend.EmailBouncedEventDataVariant2>? emailBouncedEventDataVariant2 = null,
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
            else if (IsEmailBouncedEventDataVariant2)
            {
                emailBouncedEventDataVariant2?.Invoke(EmailBouncedEventDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Resend.OutboundEmailEventData>? outbound = null,
            global::System.Action<global::Resend.EmailBouncedEventDataVariant2>? emailBouncedEventDataVariant2 = null,
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
            else if (IsEmailBouncedEventDataVariant2)
            {
                emailBouncedEventDataVariant2?.Invoke(EmailBouncedEventDataVariant2!);
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
                EmailBouncedEventDataVariant2,
                typeof(global::Resend.EmailBouncedEventDataVariant2),
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
        public bool Equals(EmailBouncedEventData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Resend.OutboundEmailEventData?>.Default.Equals(Outbound, other.Outbound) &&
                global::System.Collections.Generic.EqualityComparer<global::Resend.EmailBouncedEventDataVariant2?>.Default.Equals(EmailBouncedEventDataVariant2, other.EmailBouncedEventDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmailBouncedEventData obj1, EmailBouncedEventData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmailBouncedEventData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmailBouncedEventData obj1, EmailBouncedEventData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmailBouncedEventData o && Equals(o);
        }
    }
}
