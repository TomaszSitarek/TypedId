# TypedId
Base class for Strongly Typed Identifier.

Sample usage:
    class DutyId : TypedId<int, DutyId>
    {
        public DutyId(int id) : base(id)
        {
        }
    }
