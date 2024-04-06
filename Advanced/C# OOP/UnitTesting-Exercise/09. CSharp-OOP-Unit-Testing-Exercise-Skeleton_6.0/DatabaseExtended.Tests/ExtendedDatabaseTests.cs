using System.Runtime.CompilerServices;

namespace DatabaseExtended.Tests;

using ExtendedDatabase;
using NUnit.Framework;
using System;

[TestFixture]
public class ExtendedDatabaseTests
{
    private Database database;
    [SetUp]
    public void SetUp()
    {
        Person[] persons =
        {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko")
        };

        database = new Database(persons);

    }

    [Test]
    public void CountShouldReturnElementsCorrectly()
    {
        int actualResult = database.Count;
        int expectedResult = 11;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void CreatingDatabaseWhenCountIsMoreThan16ShouldThrowException()
    {
        Person[] persons =
        {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko"),
            new Person(12, "Moshko"),
            new Person(13, "Foshko"),
            new Person(14, "Loshko"),
            new Person(15, "Roshko"),
            new Person(16, "Boshko"),
            new Person(17, "Kokoshko")
        };

        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            database = new Database(persons);
        });

        Assert.AreEqual("Provided data length should be in range [0..16]!", exception.Message);
    }

    [Test]
    public void AddMemberCorrectly()
    {
        Person person = new Person(12, "Vasil");

        database.Add(person);
        int expectedResult = 12;
        int actualResult = database.Count;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void AddMemberWhenCountIs16AlreadyShouldThrowException()
    {
        Person[] persons =
        {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko"),
            new Person(12, "Moshko"),
            new Person(13, "Foshko"),
            new Person(14, "Loshko"),
            new Person(15, "Roshko"),
            new Person(16, "Boshko"),
        };

        database = new Database(persons);

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            database.Add(new Person(17, "Stoyko"));
        });

        Assert.AreEqual("Array's capacity must be exactly 16 integers!", exception.Message);
    }

    [Test]
    public void AddMemberWithSameNameShouldThrowException()
    {
        Person person = new Person(12, "Toshko");

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            database.Add(person);
        });

        Assert.AreEqual("There is already user with this username!", exception.Message);
    }

    [Test]
    public void AddMemberWithSameIdShouldThrowException()
    {
        Person person = new Person(11, "Vasil");

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            database.Add(person);
        });

        Assert.AreEqual("There is already user with this Id!", exception.Message);
    }

    [Test]
    public void RemoveMembersCorrectly()
    {
        int expectedResult = 10;
        database.Remove();
        Assert.AreEqual(expectedResult, database.Count);
    }


    [Test]
    public void RemoveMembersWhenDatabaseIsEmptyShouldThrowException()
    {
        database = new Database();

        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            database.Remove();
        });
    }

    [Test]
    public void FindByUsernameMethodShouldWorkCorrectly()
    {
        string expectedResult = "Gosho";
        string actualResult = database.FindByUsername("Gosho").UserName;

        Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    [TestCase("")]
    [TestCase(null)]
    public void FindByUsernameMethodShouldThrowExceptionWhenParamerIsNull(string name)
    {
        ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() =>
        {
            database.FindByUsername(name);
        });

        Assert.AreEqual("Username parameter is null!", exception.ParamName);
    }

    [Test]
    [TestCase("Vasil")]
    public void FindByUsernameMethodShouldThrowExceptionWhenUsernameDoesNotExist(string name)
    {
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            database.FindByUsername(name);
        });

        Assert.AreEqual("No user is present by this username!", exception.Message);
    }

    [Test]
    public void FindByUsernameMethodShouldBeCaseSensitive()
    {
        string expectedResult = "peShO";
        string actualResult = database.FindByUsername("Pesho").UserName;

        Assert.AreNotEqual(expectedResult, actualResult);
    }

    [Test]
    public void FindByIdShouldWorkCorrectly()
    {
        string expectedUsername = "Gosho";
        string actualUsernamme = database.FindById(2).UserName;

        Assert.AreEqual(expectedUsername, actualUsernamme);
    }

    [Test]
    public void FindByIdShouldThrowExceptionWhenIdIsNegativeNumber()
    {
        ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            database.FindById(-14);
        });

        Assert.AreEqual("Id should be a positive number!", exception.ParamName);
    }


    [Test]
    public void FindByIdShouldThrowExceptionWhenIdDoesNotExist()
    {
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            database.FindById(14);
        });

        Assert.AreEqual("No user is present by this ID!", exception.Message);
    }
}