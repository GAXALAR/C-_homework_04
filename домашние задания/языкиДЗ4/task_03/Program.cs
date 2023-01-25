int [] array = new int [ 8 ];
Console.WriteLine($"длина масива = { array.Length}");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]},");
}