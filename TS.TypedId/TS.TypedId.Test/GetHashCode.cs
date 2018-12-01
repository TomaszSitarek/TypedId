using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TS.TypedId.Test
{
    [TestClass]
    public class GetHashCode
    {
        [TestMethod]
        public void ClassNullId_GetHashCode_Returns()
            => new StringIdentityA(null).GetHashCode();

        [TestMethod]
        public void ClassSameValuesSameType_GetHashCode_SameHashCode()
            => Assert.AreEqual(new StringIdentityA("1").GetHashCode(), new StringIdentityA("1").GetHashCode());

        [TestMethod]
        public void ClassSameValuesDifferentType_GetHashCode_SameHashCode()
            => Assert.AreEqual(new StringIdentityA("1").GetHashCode(), new StringIdentityADerived("1").GetHashCode());

        [TestMethod]
        public void StructSameValuesSameType_GetHashCode_SameHashCode()
            => Assert.AreEqual(new IntIdentityA(1).GetHashCode(), new IntIdentityA(1).GetHashCode());

        [TestMethod]
        public void StructSameValuesDifferentType_GetHashCode_SameHashCode()
            => Assert.AreEqual(new IntIdentityA(1).GetHashCode(), new IntIdentityADerived(1).GetHashCode());
    }
}
