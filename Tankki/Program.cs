using System;
using System.Collections.Generic;
using System.IO;

namespace Tankki
{
  class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("AMMUTAAN TANKILLA!\n");
      List<string> lista = new List<string>();
      int num;
      do
      {
        Console.WriteLine("Valitse tankki: 1=normaali tankki ja 2=supertankki. Valinta 3 näyttää ampuneiden tankkien nimet.");
        num = int.Parse(Console.ReadLine());
        if (num == 1)
        {
          Tankki tankki = new Tankki();
          Console.WriteLine("Anna tankille nimi ");
          string nimi = Console.ReadLine();
          lista.Add(nimi);
          Console.Write(nimi + " tankki ampuu ");
          tankki.Ammu();
          Console.Write("\n");
          File.WriteAllLines("nimet.txt", lista);
        }
        if (num == 2)
        {
          Supertankki supertankki = new Supertankki();
          Console.WriteLine("Anna tankille nimi");
          string nimi = Console.ReadLine();
          lista.Add(nimi);
          Console.Write(nimi + " tankki ampuu laseria ");
          supertankki.Ammu();
          Console.Write("\n");
          File.WriteAllLines("nimet.txt", lista);
        }
        if (num == 3)
        {
         Console.WriteLine("Tankkien nimet olivat: ");
         string nimet = File.ReadAllText("nimet.txt");
         Console.WriteLine(nimet);
        }
      }
      while (num <= 3 && num >= 1);
      Console.ReadLine();
    }
  }
}
