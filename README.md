# TypedId
[![Build status](https://ci.appveyor.com/api/projects/status/hvomgv8841mautsw?svg=true)](https://ci.appveyor.com/project/TomaszSitarek/typedid)
[![NuGet](https://img.shields.io/nuget/v/TS.TypedId.svg)](https://www.nuget.org/packages/TS.TypedId/)


Base class for Strongly Typed Identifier.

Sample usage:
    class DutyId : TypedId<int, DutyId>
    {
        public DutyId(int id) : base(id)
        {
        }
    }
