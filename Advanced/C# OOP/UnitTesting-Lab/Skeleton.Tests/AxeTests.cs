using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void Setup()
        {
            axe = new Axe(10, 10);
            dummy = new Dummy(100, 10);
        }


        [Test]
        public void DurabilityShouldDecreaseAfterAttack()
        {
            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9));
        }

        [Test]
        public void AttackWithNegativeDurabilityWeaponShouldThrowException()
        {
            axe = new Axe(4, 0);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}