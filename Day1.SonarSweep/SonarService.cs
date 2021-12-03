using System.Collections.Generic;
using System.Linq;

namespace Day1.SonarSweep
{
    public class SonarService
    {
        public int CountDepthIncrease(IEnumerable<int> depthEnumerable)
        {
            var depthList = depthEnumerable?.ToList();
            var depthIncreases = 0;

            for (var depthIndex = 0; depthIndex < depthList?.Count() - 1; depthIndex++)
            {
                if (isIncrease(depthList[depthIndex], depthList[depthIndex + 1]))
                {
                    depthIncreases++;
                }
            }

            return depthIncreases;
        }

        public IEnumerable<int> SumThreeDepthMeasurement(IEnumerable<int> threeMeasurementDepthEnumerable)
        {
            var threeMeasurementDepthList = threeMeasurementDepthEnumerable?.ToList();
            var result = new List<int>();

            if (threeMeasurementDepthList != null)
            {
                for (var measurementIndex = 0; measurementIndex < threeMeasurementDepthList.Count-2; measurementIndex++)
                {
                    result.Add(threeMeasurementDepthList[measurementIndex] + threeMeasurementDepthList[measurementIndex + 1] + threeMeasurementDepthList[measurementIndex + 2]);
                }
            }

            return result;
        }
        
        private static bool isIncrease(int number1, int number2)
        {
            return number1 < number2;
        }
    }
}