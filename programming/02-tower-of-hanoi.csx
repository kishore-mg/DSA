// C# recursive program to solve tower of hanoi puzzle
using System;

int N = 4;

// A, B and C are names of rods
Hanoi.towerOfHanoi(N, 'A', 'B', 'C');

public class Hanoi {
    public static void towerOfHanoi(int n, char from_rod,
                             char to_rod, char aux_rod)
    {
        Console.WriteLine($"{n} {from_rod} {to_rod} {aux_rod}");

        if (n == 0) {
            return;
        }
        towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
        Console.WriteLine("Move disk " + n + " from rod "
                          + from_rod + " to rod " + to_rod);
        towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
    }
}
