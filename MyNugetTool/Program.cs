using System;
using System.IO;

namespace MyNugetTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory;
            Console.WriteLine($"[MyNugetTool]:{path}");
            foreach (var file in Directory.EnumerateFiles(path))
            {
                Console.WriteLine($"[MyNugetTool]:{file}");

            }
        }
    }
}
