// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Strategy bubbleSort = new BubbleSort();
Contex contex = new Contex(bubbleSort);
int[] arr = { 3, 2, 4, 5, 6, 2 };
contex.strategy.Sort(ref arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+",");
}
