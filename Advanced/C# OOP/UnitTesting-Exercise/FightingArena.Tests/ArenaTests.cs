using System.Collections.Generic;

namespace Tests;

using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

public class ArenaTests
{
    private Arena arena;
    private Warrior warrior;

    [SetUp]
    public void SetUp()
    {
        warrior = new Warrior("George", 10, 100);
        arena = new Arena();
    }

    [Test]
    public void ArenaCountShouldWorkCorrectly()
    {
        int expectedCount = 0;
        int acutalCount = arena.Count;

        Assert.AreEqual(expectedCount, acutalCount);
    }

    [Test]
    public void ArenaEnrollMethodShouldWorkCorrectly()
    {
        arena.Enroll(warrior);
        int expectedCount = 1;
        int acutalCount = arena.Count;

        Assert.AreEqual(expectedCount, acutalCount);
    }

    [Test]
    public void ArenaEnrollMethodShouldThrowExceptionIfWarriorAlreadyExist()
    {
        arena.Enroll(warrior);
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            arena.Enroll(warrior);
        });

        Assert.AreEqual("Warrior is already enrolled for the fights!", exception.Message);
    }

    [Test]
    public void ArenaFightMethodShouldWorkCorrectly()
    {
        Warrior defender = new Warrior("Ivan", 5, 100);

        arena.Enroll(defender);
        arena.Enroll(warrior);

        arena.Fight(warrior.Name, defender.Name);

        int expectedDefenderHP = 90;
        int expectedAttackerHP = 95;
        int acutalDefenderHP = defender.HP;
        int acutalAttackerHP = warrior.HP;

        Assert.AreEqual(expectedDefenderHP, acutalDefenderHP);
        Assert.AreEqual(expectedAttackerHP, acutalAttackerHP);
    }

    [TestCase("Pesho")]
    public void ArenaFightMethodShouldThrowExceptionIfAttackerDoesNotExist(string attackerName)
    {
        Warrior defender = new Warrior("Kaloqn", 5, 100);
        arena.Enroll(warrior);
        arena.Enroll(defender);

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            arena.Fight(attackerName, defender.Name);
        });

        Assert.AreEqual($"There is no fighter with name {attackerName} enrolled for the fights!", exception.Message);
    }

    [TestCase("Pesho")]
    public void ArenaFightMethodShouldThrowExceptionIfDefenderDoesNotExist(string defenderName)
    {
        Warrior defender = new Warrior("Kaloqn", 5, 100);
        arena.Enroll(warrior);
        arena.Enroll(defender);

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            arena.Fight(warrior.Name, defenderName);
        });

        Assert.AreEqual($"There is no fighter with name {defenderName} enrolled for the fights!", exception.Message);
    }

}