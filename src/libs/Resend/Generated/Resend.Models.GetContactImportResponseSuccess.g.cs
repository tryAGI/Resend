#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Resend
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetContactImportResponseSuccess : global::System.IEquatable<GetContactImportResponseSuccess>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Resend.ContactImport? ContactImport { get; init; }
#else
        public global::Resend.ContactImport? ContactImport { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContactImport))]
#endif
        public bool IsContactImport => ContactImport != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContactImport(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Resend.ContactImport? value)
        {
            value = ContactImport;
            return IsContactImport;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Resend.ContactImport PickContactImport() => IsContactImport
            ? ContactImport!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContactImport' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetContactImportResponseSuccess(global::Resend.ContactImport value) => new GetContactImportResponseSuccess((global::Resend.ContactImport?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Resend.ContactImport?(GetContactImportResponseSuccess @this) => @this.ContactImport;

        /// <summary>
        /// 
        /// </summary>
        public GetContactImportResponseSuccess(global::Resend.ContactImport? value)
        {
            ContactImport = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetContactImportResponseSuccess FromContactImport(global::Resend.ContactImport? value) => new GetContactImportResponseSuccess(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContactImport as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ContactImport?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsContactImport;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Resend.ContactImport, TResult>? contactImport = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContactImport && contactImport != null)
            {
                return contactImport(ContactImport!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Resend.ContactImport>? contactImport = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContactImport)
            {
                contactImport?.Invoke(ContactImport!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Resend.ContactImport>? contactImport = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsContactImport)
            {
                contactImport?.Invoke(ContactImport!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContactImport,
                typeof(global::Resend.ContactImport),
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
        public bool Equals(GetContactImportResponseSuccess other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Resend.ContactImport?>.Default.Equals(ContactImport, other.ContactImport) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetContactImportResponseSuccess obj1, GetContactImportResponseSuccess obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetContactImportResponseSuccess>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetContactImportResponseSuccess obj1, GetContactImportResponseSuccess obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetContactImportResponseSuccess o && Equals(o);
        }
    }
}
