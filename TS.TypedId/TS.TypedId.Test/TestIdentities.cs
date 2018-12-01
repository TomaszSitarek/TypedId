namespace TS.TypedId.Test
{
    class IntIdentityA : TypedId<int, IntIdentityA>
    {
        public IntIdentityA(int id) : base(id)
        {
        }
    }

    class IntIdentityADerived : IntIdentityA
    {
        public IntIdentityADerived(int id) : base(id)
        {
        }
    }

    class IntIdentityB : TypedId<int, IntIdentityB>
    {
        public IntIdentityB(int id) : base(id)
        {
        }
    }

    class StringIdentityA : TypedId<string, StringIdentityA>
    {
        public StringIdentityA(string id) : base(id)
        {
        }
    }

    class StringIdentityADerived : StringIdentityA
    {
        public StringIdentityADerived(string id) : base(id)
        {
        }
    }

    class StringIdentityB : TypedId<string, StringIdentityB>
    {
        public StringIdentityB(string id) : base(id)
        {
        }
    }
}
