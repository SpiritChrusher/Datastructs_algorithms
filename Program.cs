using System;
using System.Numerics;

int[] vector = new[] { 4, 8, 10, 13, 16, 17, 21, 25, 26, 27, 31, 35, 37, 41, 44, 46, 47, 50, 51, 52, 54, 58, 62, 64, 65, 68, 71, 73 };
Console.WriteLine(vector.Length);

Console.WriteLine($" megoldás: {full_search_for(vector, 17)}");

Console.WriteLine($" rekurzív megoldás: {full_search_rec(vector, 17)}");


