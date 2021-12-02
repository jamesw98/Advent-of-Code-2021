using System;

class Day2_p1 {
    public static void Main() {
        string[] lines = System.IO.File.ReadAllLines("d2_input.txt");

        Console.WriteLine(Part1(lines));
        Console.WriteLine(Part2(lines));
    }

    /**
     * AoC 2021 Day 2 Part 1
     * 
     * Find the product of the final depth and final horizontal travel distance
     * after calculating using simple movement
     */
    public static int Part1(string[] lines) {
        int horiz = 0;
        int depth = 0;
        
        // loop through input
        foreach (string line in lines) {
            // get the direction you're going 
            string dir = line.Split(" ")[0];
            // get the distance you're going
            int value = int.Parse(line.Split(" ")[1]);

            // update horizontal distance
            if (dir.Equals("forward")) horiz += value;
            // going down? make depth bigger
            else if (dir.Equals("down")) depth += value;
            // going up? make depth smaller
            else depth -= value;
        }
        return horiz * depth;
    }

    /**
     * AoC 2021 Day 2 Part 2
     * 
     * Find the product of the final depth and final horizontal travel distance
     * after calculating using aim and horizontal movement 
     */
    public static int Part2(string[] lines) {
        int horiz = 0;
        int depth = 0;
        int aim = 0;

        foreach (string line in lines) {
            string dir = line.Split(" ")[0];
            int value = int.Parse(line.Split(" ")[1]);

            // update the horizontal and depth using the aim of the sub
            if (dir.Equals("forward")) {
                horiz += value;
                depth += value * aim;
            }
            // going down? make aim bigger
            else if (dir.Equals("down")) aim += value;
            // going up? make aim smaller
            else aim -= value;
        }

        return horiz * depth;
    }
}