using System;
using Common;

namespace Day2.Dive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fileService = new FileService();

            FirstAssignment(fileService);
        }

        static void FirstAssignment(FileService fileService)
        {
            var inputCommands = fileService.ReadFile("..//..//..//InputFiles//Day2-input-a.txt");
            var resultingDepth = NavigationService.GetDepth(inputCommands);
            var locationResult = NavigationService.GetLocation(inputCommands);
            
            Console.WriteLine($"First answer: {resultingDepth * locationResult}");
        }
    }
}