using System;

namespace Tankki
{
  public class Tankki : IAmmu
  {
    public virtual void Ammu()
    {
      Console.WriteLine("PUM!");
    }
  }
}
