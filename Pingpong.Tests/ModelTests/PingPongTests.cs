using Microsoft.VisualStudio.TestTools.UnitTesting;
using pingpong;

namespace pingpong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_FollowtheRules_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(30));
    }
  }
}
