using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySweepstakes;

namespace UnitTests
{
    [TestClass]
    public class ISweepstakesManagerTests
    {
        [TestMethod] // Test 1
        // Must make underlying queue element public in order to run test
        public void Queue_Add3Sweepstakes_QueueCountIs3()
        {
            // Arrange
            SweepstakesQueueManager queue = new SweepstakesQueueManager();
            Sweepstakes sweepstakes1 = new Sweepstakes("1");
            Sweepstakes sweepstakes2 = new Sweepstakes("2");
            Sweepstakes sweepstakes3 = new Sweepstakes("3");
            int expected = 3;
            int actual;

            // Act
            queue.InsertSweepstakes(sweepstakes1);
            queue.InsertSweepstakes(sweepstakes2);
            queue.InsertSweepstakes(sweepstakes3);
            actual = queue.queue.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 2
        // Must make underlying queue element public in order to run test
        public void Queue_Add3Sweepstakes_RemoveSweepstakes_SweepstakesIndex0IsSweepstakes2()
        {
            // Arrange
            SweepstakesQueueManager queue = new SweepstakesQueueManager();
            Sweepstakes sweepstakes1 = new Sweepstakes("1");
            Sweepstakes sweepstakes2 = new Sweepstakes("2");
            Sweepstakes sweepstakes3 = new Sweepstakes("3");
            string expected = "2";
            string actual;

            // Act
            queue.InsertSweepstakes(sweepstakes1);
            queue.InsertSweepstakes(sweepstakes2);
            queue.InsertSweepstakes(sweepstakes3);
            queue.GetSweepstakes();
            actual = queue.queue.ElementAt(0).Name;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 3
        // Must make underlying stack element public in order to run test
        public void Stack_Add3Sweepstakes_StackCountIs3()
        {
            // Arrange
            SweepstakesStackManager stack = new SweepstakesStackManager();
            Sweepstakes sweepstakes1 = new Sweepstakes("1");
            Sweepstakes sweepstakes2 = new Sweepstakes("2");
            Sweepstakes sweepstakes3 = new Sweepstakes("3");
            int expected = 3;
            int actual;

            // Act
            stack.InsertSweepstakes(sweepstakes1);
            stack.InsertSweepstakes(sweepstakes2);
            stack.InsertSweepstakes(sweepstakes3);
            actual = stack.stack.Count;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Test 4
        // Must make underlying stack element public in order to run test
        public void Stack_Add3Sweepstakes_RemoveSweepstakes_SweepstakesIndex0IsSweepstakes1()
        {
            // Arrange
            SweepstakesStackManager stack = new SweepstakesStackManager();
            Sweepstakes sweepstakes1 = new Sweepstakes("1");
            Sweepstakes sweepstakes2 = new Sweepstakes("2");
            Sweepstakes sweepstakes3 = new Sweepstakes("3");
            string expected = "1";
            string actual;

            // Act
            stack.InsertSweepstakes(sweepstakes1);
            stack.InsertSweepstakes(sweepstakes2);
            stack.InsertSweepstakes(sweepstakes3);
            stack.GetSweepstakes();
            actual = stack.stack.ElementAt(0).Name;

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
