using System;
using System.Collections.Generic;

namespace PingPongProgram
{
  public class PingPong
  {
    public static List<string> isPingPong(int number)
    {
      List<string> result = new List<string> {};
      for (int i=1 ; i <= number; i++ )
      {
        if (i % 15 == 0)
        {
          result.Add("ping-pong");
          Console.WriteLine("ping-pong");
        }
        else if (i % 5 == 0)
        {
          result.Add("pong");
          Console.WriteLine("pong");

        }
        else if (i % 3 == 0)
        {
          result.Add("ping");
          Console.WriteLine("ping");
        }
        else
        {
          result.Add(i.ToString());
          Console.WriteLine(i.ToString());
        }
      }

      return result;
    }

    public static void Main()
    {
      isPingPong(100);
    }
  }
}
