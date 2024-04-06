using System.ComponentModel;

namespace Tests;

using FightingArena;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using static System.Net.Mime.MediaTypeNames;

[TestFixture]
public class WarriorTests
{
    private const int MIN_ATTACK_HP = 30;
    private Warrior warrior;

    [SetUp]
    public void SetUp()
    {
        warrior = new Warrior("George", 10, 100);
    }

    [Test]
    public void CreateWarriorShouldWorkCorrectly()
    {
        string expectedName = "George";
        int expectedDamage = 10;
        int expectedHP = 100;

        string actualName = warrior.Name;
        int actualDamage = warrior.Damage;
        int actualHP = warrior.HP;

        Assert.AreEqual(expectedName, actualName);
        Assert.AreEqual(expectedDamage, actualDamage);
        Assert.AreEqual(expectedHP, actualHP);
    }

    [TestCase(null)]
    [TestCase("")]
    public void WarriorNameCannotBeNullOrWhiteSpaceShouldThrowException(string name)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            warrior = new Warrior(name, 10, 100);
        });

        Assert.AreEqual("Name should not be empty or whitespace!", exception.Message);
    }

    [TestCase(0)]
    [TestCase(-15)]
    public void WarriorDamageCannotBeZeroOrNegativeShouldThrowException(int damage)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            warrior = new Warrior("George", damage, 100);
        });

        Assert.AreEqual("Damage value should be positive!", exception.Message);
    }

    [TestCase(-15)]
    public void WarriorHPCannotBeNegativeShouldThrowException(int HP)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            warrior = new Warrior("George", 10, HP);
        });

        Assert.AreEqual("HP should not be negative!", exception.Message);
    }

    [Test]
    public void WarriorAttackMethodShouldWorkCorrectly()
    {
        Warrior currentWarrior = new Warrior("Ivan", 5, 100);

        warrior.Attack(currentWarrior);

        int thisExpectedWarriorHP = 95;
        int currentWarriorExpectedHP = 90;

        int acutalThisWarriorHP = warrior.HP;
        int acutalCurrentWarriorHP = currentWarrior.HP;

        Assert.AreEqual(thisExpectedWarriorHP, acutalThisWarriorHP);
        Assert.AreEqual(currentWarriorExpectedHP, acutalCurrentWarriorHP);
    }

    [Test]
    public void WarriorShouldNotAttackIfHPIsBelowMinimum()
    {
        warrior = new Warrior("George", 10, 29);
        Warrior defender = new Warrior("Ivan", 100, 100);

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            warrior.Attack(defender);
        });

        Assert.AreEqual("Your HP is too low in order to attack other warriors!", exception.Message);
    }

    [Test]
    public void AttackerWarriorDamageIsMoreThanDefenderWarriorHpShouldMakeDenfenderHPToZero()
    {
        Warrior attacker = new Warrior("Stoyan", 200, 100);
        Warrior defender = new Warrior("Ivan", 10, 100);

        attacker.Attack(defender);

        int expectedDefenderHP = 0;
        int acutalDefenderHP = defender.HP;

        Assert.AreEqual(expectedDefenderHP, acutalDefenderHP);
    }

    [Test]
    public void AttackerWarriorShouldNotAttackDefenderWithLessThanMinimuHPShouldThrowException()
    {
        Warrior attacker = new Warrior("Stoyan", 10, 100);
        Warrior defender = new Warrior("Ivan", 10, 20);

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            attacker.Attack(defender);
        });

        Assert.AreEqual($"Enemy HP must be greater than {MIN_ATTACK_HP} in order to attack him!", exception.Message);
    }

    [Test] 
    public void AttackerShouldNotAttackDefenderWithMoreThanDamageThanAttackersHPShouldThrowException()
    {
        Warrior attacker = new Warrior("Stoyan", 10, 100);
        Warrior defender = new Warrior("Ivan", 200, 500);

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            attacker.Attack(defender);
        });

        Assert.AreEqual($"You are trying to attack too strong enemy", exception.Message);
    }
}