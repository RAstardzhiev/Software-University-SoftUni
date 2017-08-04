namespace Skeleton.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private const int AttackPoints = 10;
        private const int DummyHealth = 10;
        private const int DummyExperience = 10;

        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.dummy = new Dummy(DummyHealth, DummyExperience);
        }

        [Test]
        public void DummyLosesHealthWhenAttacked()
        {
            // Arrange

            // Act
            this.dummy.TakeAttack(3);

            // Assert
            Assert.IsTrue(this.dummy.Health < DummyHealth, "Dummy doesn't lose health after an atack");
        }

        [Test]
        public void DeadDummyThrowsExceptionWhenAttacked()
        {
            // Arrange

            // Act
            this.dummy.TakeAttack(6);
            this.dummy.TakeAttack(6);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(6));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            // Arrange

            // Act
            while (!this.dummy.IsDead())
            {
                this.dummy.TakeAttack(AttackPoints);
            }

            var gotExperience = this.dummy.GiveExperience();

            // Assert
            Assert.AreEqual(10, gotExperience, "Dead dummy doesn't give experience");
        }

        [Test]
        public void AliveDummyCannotGiveExperience()
        {
            // Arrange

            // Act

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
