using System;
using Datastructs_algorithms;

int[] vector = new[] { 4, 8, 10, 13, 16, 17, 21, 25, 26, 27, 31, 35, 37, 41, 44, 46, 47, 50, 51, 52, 54, 58, 62, 64, 65, 68, 71, 73, 76 };
Console.WriteLine($"darabszám: {vector.Length}");

Console.WriteLine($"teljes for megoldás: {FullSearches.full_search_for(vector, 62)}");

Console.WriteLine($"teljes rekurzív megoldás: {FullSearches.full_search_rec(vector, 62)}");


Console.WriteLine($"lineris for megoldás: {LinearSearches.lin_search_for(vector, 71)}");

Console.WriteLine($"lineris recurzív megoldás: {LinearSearches.lin_search_rec(vector, 76)}");


Console.WriteLine($"teljes while megoldás: {FullSearches.full_search_while(vector, 17)}");

Console.WriteLine($"bináris while megoldás: {BinarySearches.bin_search_while(vector, 10)}");

Console.WriteLine($"bináris while megoldás: {BinarySearches.bin_search_while(vector, 71)}");

Console.WriteLine($"bináris rec megoldás: {BinarySearches.bin_search_rec(vector, 71)}"); //44 az a 15. elem a 28ból

Console.WriteLine($"bináris rec2 megoldás: {BinarySearches.bin_search_rec2(vector, 64, 0, 29)}");
Console.WriteLine($"bináris rec megoldás: {BinarySearches.bin_search_rec(vector, 64)}");