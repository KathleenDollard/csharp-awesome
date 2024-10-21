
int[] x1 = [1, 2, 3, 4];   // 1, 2, 3, 4
int[] x3 = [.. x1[1..^1]];     // 2,3
foreach (var i in x3)
{
    Console.WriteLine(i);
}
