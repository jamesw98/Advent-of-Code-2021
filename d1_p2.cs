using System;

class Day1_p2 {
    static void Main() {
        string[] lines = System.IO.File.ReadAllLines("d1_input.txt");

        int total = 0;
        int current = GetWindowValue(lines, 0);

        for (int i = 1; i < lines.Length - 2; i++) {
            int next = GetWindowValue(lines, i);

            if (current < next) {
                total++;
            }

            current = next;
        }
        Console.WriteLine(total);
    }
    
    static int GetWindowValue(string[] lines, int window_index) {
        int sum = 0;
        for (int i = 0; i < 3; i++) {
            sum += int.Parse(lines[window_index + i]);
        }
        return sum;
    }   
}