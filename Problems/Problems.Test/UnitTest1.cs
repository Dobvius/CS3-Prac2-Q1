using NUnit.Framework;

namespace Problems.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("5,1:hello", Prefix("hello"));
            Assert.AreEqual("0,0:", Prefix(""));
            Assert.AreEqual("27,5:what ... did you say?? ", Prefix("what ... did you say?? "));
        }
    }
}