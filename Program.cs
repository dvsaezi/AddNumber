using System;
using System.Threading.Tasks;
namespace AddNumber
{
    static class Program
    {
        static int AddNumber(int x)
        {
            return x + 1;
        }
        static async Task Main() => await OwO();

        private static Task OwO()
        {
            Console.WriteLine("Enter the number you want to know the next value that comes after : ");
            var input = int.Parse(Console.ReadLine());
            var res = AddNumber(input);
            Console.WriteLine($"The next number that comes after {input} is {res}");
            Console.ReadLine();
            return Task.CompletedTask;
        }
    }
}