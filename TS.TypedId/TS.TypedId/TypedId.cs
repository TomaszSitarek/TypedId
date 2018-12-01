using System;

namespace TS.TypedId
{
    /// <summary>
    /// Base class for strongly typed identifiers. Usage: class DutyId : TypedId<int, DutyId>
    /// </summary>
    /// <typeparam name="TId">Type of identifier to be wrapped, e.g. int</typeparam>
    /// <typeparam name="TDerived">Type of class deriving from TypedId<,></typeparam>
    public abstract class TypedId<TId, TDerived> : IEquatable<TDerived>
        where TDerived : TypedId<TId, TDerived>
    {
        public TId Id { get; }

        public TypedId(TId id)
        {
            this.Id = id;
        }

        public override bool Equals(object obj)
            => this.Equals(obj as TDerived);

        public bool Equals(TDerived p)
        {
            if (Object.ReferenceEquals(p, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            if (this.GetType() != p.GetType())
            {
                return false;
            }

            return Object.Equals(this.Id, p.Id);
        }

        public override int GetHashCode()
            => this.Id?.GetHashCode() ?? 0;

        public static bool operator ==(TypedId<TId, TDerived> lhs, TypedId<TId, TDerived> rhs)
        {
            if (Object.ReferenceEquals(lhs, null))
            {
                if (Object.ReferenceEquals(rhs, null))
                {
                    return true;
                }

                return false;
            }

            return lhs.Equals(rhs as TDerived);
        }

        public static bool operator !=(TypedId<TId, TDerived> lhs, TypedId<TId, TDerived> rhs)
            => !(lhs == rhs);
    }
}
