using System;

class Day1_p1 {
  static void Main() {
      string[] lines = System.IO.File.ReadAllLines("d1_input.txt");

      int total = 0;

      for (int i = 1; i < lines.Length - 1; i++) {
        int current = Int32.Parse(lines[i]);

        if (current > Int32.Parse(lines[i - 1])) {
          total++;
          Console.WriteLine("Increase")
        }
        else{
          Console.WriteLine("Decrease")
        }
      }
      Console.WriteLine(total);
  }
}
