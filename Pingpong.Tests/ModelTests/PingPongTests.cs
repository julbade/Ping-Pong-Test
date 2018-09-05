using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongProgram;
using System.Collections.Generic;

namespace PingPongProgram.Tests
{
  [TestClass]
  public class PingPongTest
  {
    // [TestMethod]
    // public void isPingPong_isThree_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("Ping", testPingPong.isPingPong(3));
    // }
    //
    // [TestMethod]
    // public void isPingPong_isFive_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("Pong", testPingPong.isPingPong(5));
    // }
    //
    // [TestMethod]
    // public void isPingPong_isFifteen_True()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("Ping-Pong", testPingPong.isPingPong(15));
    // }

    [TestMethod]
    public void isPingPong_untilNumber_True()
    {
      PingPong testPingPong = new PingPong();
      List<string> testList = new List<string> {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong", "16"};

      CollectionAssert.AreEqual(testList, PingPong.isPingPong(16));
    }
  }
}
