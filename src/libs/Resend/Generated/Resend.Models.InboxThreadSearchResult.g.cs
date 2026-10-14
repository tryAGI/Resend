#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InboxThreadSearchResult : global::System.IEquatable<InboxThreadSearchResult>
    {
        /// <summary>
        /// A thread as it appears in the list of an inbox's threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Resend.InboxThread? InboxThread { get; init; }
#else
        public global::Resend.InboxThread? InboxThread { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InboxThread))]
#endif
        public bool IsInboxThread => InboxThread != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInboxThread(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.InboxThread? value)
        {
            value = InboxThread;
            return IsInboxThread;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThread PickInboxThread() => InboxThread is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InboxThread' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Resend.InboxThreadSearchResultVariant2? InboxThreadSearchResultVariant2 { get; init; }
#else
        public global::Resend.InboxThreadSearchResultVariant2? InboxThreadSearchResultVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InboxThreadSearchResultVariant2))]
#endif
        public bool IsInboxThreadSearchResultVariant2 => InboxThreadSearchResultVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInboxThreadSearchResultVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.InboxThreadSearchResultVariant2? value)
        {
            value = InboxThreadSearchResultVariant2;
            return IsInboxThreadSearchResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Resend.InboxThreadSearchResultVariant2 PickInboxThreadSearchResultVariant2() => InboxThreadSearchResultVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InboxThreadSearchResultVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InboxThreadSearchResult(global::Resend.InboxThread value) => new InboxThreadSearchResult((global::Resend.InboxThread?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Resend.InboxThread?(InboxThreadSearchResult @this) => @this.InboxThread;

        /// <summary>
        ///
        /// </summary>
        public InboxThreadSearchResult(global::Resend.InboxThread? value)
        {
            InboxThread = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InboxThreadSearchResult FromInboxThread(global::Resend.InboxThread? value) => new InboxThreadSearchResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InboxThreadSearchResult(global::Resend.InboxThreadSearchResultVariant2 value) => new InboxThreadSearchResult((global::Resend.InboxThreadSearchResultVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Resend.InboxThreadSearchResultVariant2?(InboxThreadSearchResult @this) => @this.InboxThreadSearchResultVariant2;

        /// <summary>
        ///
        /// </summary>
        public InboxThreadSearchResult(global::Resend.InboxThreadSearchResultVariant2? value)
        {
            InboxThreadSearchResultVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InboxThreadSearchResult FromInboxThreadSearchResultVariant2(global::Resend.InboxThreadSearchResultVariant2? value) => new InboxThreadSearchResult(value);

        /// <summary>
        ///
        /// </summary>
        public InboxThreadSearchResult(
            global::Resend.InboxThread? inboxThread,
            global::Resend.InboxThreadSearchResultVariant2? inboxThreadSearchResultVariant2
            )
        {
            InboxThread = inboxThread;
            InboxThreadSearchResultVariant2 = inboxThreadSearchResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InboxThreadSearchResultVariant2 as object ??
            InboxThread as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InboxThread?.ToString() ??
            InboxThreadSearchResultVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInboxThread && IsInboxThreadSearchResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Resend.InboxThread, TResult>? inboxThread = null,
            global::System.Func<global::Resend.InboxThreadSearchResultVariant2, TResult>? inboxThreadSearchResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InboxThread is { } __value0 && inboxThread != null)
            {
                return inboxThread(__value0);
            }
            else if (InboxThreadSearchResultVariant2 is { } __value1 && inboxThreadSearchResultVariant2 != null)
            {
                return inboxThreadSearchResultVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Resend.InboxThread>? inboxThread = null,

            global::System.Action<global::Resend.InboxThreadSearchResultVariant2>? inboxThreadSearchResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InboxThread is { } __value0)
            {
                inboxThread?.Invoke(__value0);
            }
            else if (InboxThreadSearchResultVariant2 is { } __value1)
            {
                inboxThreadSearchResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Resend.InboxThread>? inboxThread = null,
            global::System.Action<global::Resend.InboxThreadSearchResultVariant2>? inboxThreadSearchResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InboxThread is { } __value0)
            {
                inboxThread?.Invoke(__value0);
            }
            else if (InboxThreadSearchResultVariant2 is { } __value1)
            {
                inboxThreadSearchResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InboxThread,
                typeof(global::Resend.InboxThread),
                InboxThreadSearchResultVariant2,
                typeof(global::Resend.InboxThreadSearchResultVariant2),
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
        public bool Equals(InboxThreadSearchResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Resend.InboxThread?>.Default.Equals(InboxThread, other.InboxThread) &&
                global::System.Collections.Generic.EqualityComparer<global::Resend.InboxThreadSearchResultVariant2?>.Default.Equals(InboxThreadSearchResultVariant2, other.InboxThreadSearchResultVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InboxThreadSearchResult obj1, InboxThreadSearchResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InboxThreadSearchResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InboxThreadSearchResult obj1, InboxThreadSearchResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InboxThreadSearchResult o && Equals(o);
        }
    }
}
