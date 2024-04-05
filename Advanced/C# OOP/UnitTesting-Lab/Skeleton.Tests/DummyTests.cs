using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
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
        public void HealthShouldDecreaseAfterAttack()
        {
            dummy.TakeAttack(10);

            Assert.AreEqual(90, dummy.Health);
        }

        [Test]
        public void DummyWithNegativeHealthGetsAttackedShouldThrowException()
        {
            dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
        }

        [Test]
        public void DummyShouldGiveExperienceAfterDead()
        {
            dummy = new Dummy(0, 10);
            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [Test]
        public void DummyShouldThrowErrorIfGiveExperienceIsCalled()
        {
            dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}