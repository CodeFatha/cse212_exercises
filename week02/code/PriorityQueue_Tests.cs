using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and priorities - Bheki(2), Lucas(1), Kelvin(3) and Mbusi(4)
    // Expected Result: Kelvin
    // Defect(s) Found: for loop wasn't going all the way to the last element, comparison included equal values
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bheki", 2);
        priorityQueue.Enqueue("Lucas", 1);
        priorityQueue.Enqueue("Kelvin", 3);
        priorityQueue.Enqueue("Mbusi", 4);

        var expectedResult = "Mbusi";

        var result = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    // Scenario: Create a queue with the following people and priorities - Bheki(2), Lucas(1), Kelvin(1) and Mbusi(3)
    // Expected Result: Mbusi, Bheki, Lucas, Kelvin
    // Defect(s) Found: Item was not getting removed
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bheki", 2);
        priorityQueue.Enqueue("Lucas", 1);
        priorityQueue.Enqueue("Kelvin", 1);
        priorityQueue.Enqueue("Mbusi", 3);

        var expectedResult = new List<string> { "Mbusi", "Bheki", "Lucas", "Kelvin" };

        var index = 0;
        while (priorityQueue.GetLength() > 0)
        {
            var result = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[index], result);
            index++;
        }
    }

    // Add more test cases as needed below.
}