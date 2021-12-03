using Day1.SonarSweep;
using NUnit.Framework;
using FluentAssertions;

namespace Days.Tests.Day1
{
    [TestFixture]
    public class Tests
    {
        private SonarService _sonarService = new SonarService();

        [SetUp]
        public void Setup()
        {
            
        }
        
        [TestCase(new[] {1, 1}, 0)]
        [TestCase(new[] {1, 2}, 1)]
        [TestCase(new[] {2, 1}, 0)]
        [TestCase(new[] {1, 2, 3, 4}, 3)]
        [TestCase(new[] {1, 2, 2, 2, 2, 1}, 1)]
        [TestCase(null, 0)]
        [Test]
        public void Should_produce_the_correct_result_for_depth_increase_calculation(int[] testcase, int expectedResult)
        {
            _sonarService.CountDepthIncrease(testcase).Should().Be(expectedResult);
        }

        [TestCase(new[] {0, 0, 0}, new[] {0})]
        [TestCase(new[] {0, 0, 1}, new[] {1})]
        [TestCase(new[] {1, 0, 0, 0}, new[] {1, 0})]
        [TestCase(new[] {1, 0, 1, 0}, new[] {2, 1})]
        [Test]
        public void Should_produce_the_correct_result_for_three_measurement_data(int[] testcase, int[] expectedResult)
        {
            _sonarService.SumThreeDepthMeasurement(testcase).Should().BeEquivalentTo(expectedResult);
        }
    }
    

}