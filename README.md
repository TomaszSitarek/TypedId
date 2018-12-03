# TypedId
[![Build status](https://ci.appveyor.com/api/projects/status/hvomgv8841mautsw?svg=true)](https://ci.appveyor.com/project/TomaszSitarek/typedid)

Base class for Strongly Typed Identifier.

Sample usage:
    class DutyId : TypedId<int, DutyId>
    {
        public DutyId(int id) : base(id)
        {
        }
    }
