namespace UnitTests
{
    [TestClass]
    public class BehaviorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string  in1 = "1,", 
                    in2 = "2,", 
                    in3 = "3", 
                    desiredOutput = "1,2,3";

            var     behavior = new ConsoleApp1.Behavior();

            var     result = behavior.ConcatenateThreeStrings(in1, in2, in3);

            Assert.AreEqual(desiredOutput, result);
        }
    }
}