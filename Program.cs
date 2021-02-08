using System;
using Datastructs_algorithms;

int[] vector = new[] { 4, 8, 10, 13, 16, 17, 21, 25, 26, 27, 31, 35, 37, 41, 44, 46, 47, 50, 51, 52, 54, 58, 62, 64, 65, 68, 71, 73 };
Console.WriteLine(vector.Length);

Console.WriteLine($"teljes for megoldás: {FullSearches.full_search_for(vector, 17)}");

Console.WriteLine($"rekurzív megoldás: {FullSearches.full_search_rec(vector, 17)}");


Console.WriteLine($"lineris for megoldás: {LinearSearches.lin_search_for(vector, 64)}");

Console.WriteLine($"lineris recurzív megoldás: {LinearSearches.lin_search_rec(vector, 64)}");
