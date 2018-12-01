using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TS.TypedId.Test
{
    [TestClass]
    public class NotEqualOperator
    {
        [TestMethod]
        public void StructNullNull_opEqual_True()
            => Assert.IsFalse((IntIdentityA)null != null);

        [TestMethod]
        public void StructNullNotNullClass_opEqual_False()
            => Assert.IsTrue((IntIdentityA)null != new IntIdentityA(1));

        [TestMethod]
        public void StructNullNotNullDerivedClass_opEqual_False()
            => Assert.IsTrue((IntIdentityA)null != new IntIdentityADerived(1));

        [TestMethod]
        public void StructSameValueSameTypes_opEqual_False()
            => Assert.IsFalse(new IntIdentityA(1) != new IntIdentityA(1));

        [TestMethod]
        public void StructSameValueDifferentTypes_opEqual_False()
            => Assert.IsTrue(new IntIdentityADerived(1) != new IntIdentityA(1));

        [TestMethod]
        public void StructDifferentValueSameTypes_opEqual_False()
            => Assert.IsTrue(new IntIdentityA(1) != new IntIdentityA(2));

        [TestMethod]
        public void StructDifferentValueDifferentTypes_opEqual_False()
            => Assert.IsTrue(new IntIdentityA(1) != new IntIdentityADerived(2));

        [TestMethod]
        public void ClassNullNull_opEqual_True()
            => Assert.IsFalse((StringIdentityA)null != null);

        [TestMethod]
        public void ClassNullNotNullClass_opEqual_False()
            => Assert.IsTrue((StringIdentityA)null != new StringIdentityA("1"));

        [TestMethod]
        public void ClassNullNotNullDerivedClass_opEqual_False()
            => Assert.IsTrue((StringIdentityA)null != new StringIdentityADerived("1"));

        [TestMethod]
        public void ClassSameValueSameTypes_opEqual_False()
            => Assert.IsFalse(new StringIdentityA("1") != new StringIdentityA("1"));

        [TestMethod]
        public void ClassSameValueDifferentTypes_opEqual_False()
            => Assert.IsTrue(new StringIdentityADerived("1") != new StringIdentityA("1"));

        [TestMethod]
        public void ClassDifferentValueSameTypes_opEqual_False()
            => Assert.IsTrue(new StringIdentityA("1") != new StringIdentityA("2"));

        [TestMethod]
        public void ClassDifferentValueDifferentTypes_opEqual_False()
            => Assert.IsTrue(new StringIdentityA("1") != new StringIdentityADerived("2"));

        [TestMethod]
        public void ClassNullIdNullId_opEqual_True()
            => Assert.IsFalse(new StringIdentityA(null) != new StringIdentityA(null));

        [TestMethod]
        public void ClassNullIdNotNullIdClass_opEqual_False()
            => Assert.IsTrue(new StringIdentityA(null) != new StringIdentityA("1"));

        [TestMethod]
        public void ClassNullIdNotNullIdDerivedClass_opEqual_False()
            => Assert.IsTrue(new StringIdentityA(null) != new StringIdentityADerived("1"));

        [TestMethod]
        public void ClassNullIdNullIdDerivedClass_opEqual_False()
            => Assert.IsTrue(new StringIdentityA(null) != new StringIdentityADerived(null));
    }
}
