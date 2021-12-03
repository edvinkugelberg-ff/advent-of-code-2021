using System;
using System.Linq;
using System.Runtime.InteropServices;
using Common;

namespace Day1.SonarSweep
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileService = new FileService();
            var sonarService = new SonarService();
            
            FirstAssignment(fileService, sonarService);
            SecondAssignment(fileService, sonarService);
        }

        static void FirstAssignment(FileService fileService, SonarService sonarService)
        {
            var inputDepths = fileService.ReadFile("..//..//..//..//InputFiles//Day1-input-a.txt");
            var inputDepthInts = inputDepths.Select(int.Parse).ToList();
            var depthIncreaseResult = sonarService.CountDepthIncrease(inputDepthInts);
            
            Console.WriteLine($"First answer: {depthIncreaseResult}");
        }

        static void SecondAssignment(FileService fileService, SonarService sonarService)
        {
            var inputThreeMeasurementDepths = fileService.ReadFile("..//..//..//..//InputFiles//Day1-input-b.txt");
            var inputThreeMeasurementDepthInts = inputThreeMeasurementDepths.Select(depths => int.Parse(depths)).ToList();
            var depthInts = sonarService.SumThreeDepthMeasurement(inputThreeMeasurementDepthInts);
            var depthIncreaseResult = sonarService.CountDepthIncrease(depthInts);
            
            Console.WriteLine($"Second answer: {depthIncreaseResult}");
        }
    }
}