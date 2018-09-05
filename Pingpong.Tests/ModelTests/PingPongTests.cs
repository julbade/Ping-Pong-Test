using Microsoft.VisualStudio.TestTools.UnitTesting;
using pingpong;

namespace pingpong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest
  {
    [TestMethod]
    public void IsPingPong_FollowtheRules_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      List<string> testList = new List<string>{"1", "2", "ping"};
      CollectionAssert.AreEqual(testList, testPingPong.IsPingPong(3));
    }
  }
}
