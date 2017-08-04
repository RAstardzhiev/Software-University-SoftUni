namespace Skeleton.Tests
{
    using FakeObjects;
    using Interfaces;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class HeroTests
    {
        private const string HeroName = "Hero";

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            // Arrange
            var fakeTarget = new FakeDeadTarget();
            var fakeWeapon = new FakeWeapon();
            var hero = new Hero(HeroName, fakeWeapon);

            // Act
            hero.Attack(fakeTarget);
            var expectedExperience = fakeTarget.GiveExperience();

            // Assert
            Assert.AreEqual(expectedExperience, hero.Experience);
        }

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDiesMoqVersion()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(ft => ft.Health).Returns(0);
            fakeTarget.Setup(ft => ft.GiveExperience()).Returns(10);
            fakeTarget.Setup(ft => ft.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero(HeroName, fakeWeapon.Object);

            // Act
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(10, hero.Experience);
        }
    }
}
