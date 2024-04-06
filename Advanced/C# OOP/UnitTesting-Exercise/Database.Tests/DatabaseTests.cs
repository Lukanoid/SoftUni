namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        Database database;

        [SetUp]
        public void SetUp()
        {
            database = new Database(1 ,2);
        }

        [Test]
        [TestCase(12, 122)]
        public void ConstructorWithValidInput(params int[] input)
        {
            database = new Database(input);
        }

        [Test]
        public void CountMethodCorrectlyWorking()
        {
            int expectedResult = 2;

            int actualResult = database.Count;

            Assert.NotNull(database);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(4)]
        public void AddElementShouldWorkCorrectly(int element)
        {
            int countResult = 3;

            database.Add(element);

            int actualResult = database.Count;

            Assert.AreEqual(countResult, actualResult);
        }

        [Test]
        [TestCase(17)]
        public void AddElementShouldExceptionIfCountIsMoreThan16(int element)
        {
            database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(element);
            });
        }


        [Test]
        public void RemoveLastElementShouldWorkCorrectly()
        {
            int countResult = 1;

            database.Remove();

            int actualResult = database.Count;

            Assert.AreEqual(countResult, actualResult);
        }

        [Test]
        public void RemoveElementFromEmptyDatabaseShouldThrowException()
        {
            database = new Database(1);

            database.Remove();

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [Test]
        [TestCase(new int[] {1, 2, 3, 4})]
        public void DatabaseFetchMethodShouldReturnCorrectArray(int[] data)
        {
            database = new Database(data);
            int[] actual = database.Fetch();

            Assert.AreEqual(data, actual);
        }
    }
    
}
