# TypedId
Base class for your Strongly Typed Identifier

Sample usage:
    class DutyId : TypedId<int, DutyId>
    {
        public DutyId(int id) : base(id)
        {
        }
    }
