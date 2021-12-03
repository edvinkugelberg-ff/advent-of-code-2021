using System.Collections.Generic;
using Day2.Dive;
using FluentAssertions;
using NUnit.Framework;

namespace Days.Tests.Day2
{
    [TestFixture]
    public class NavigationServiceTests
    {
        [TestCase(new[] {"down 1", "up 1"}, 0)]
        [TestCase(new[] {"down 1", "down 1"}, 2)]
        [TestCase(new[] {"down 5", "up 1"}, 4)]
        [Test]
        public void WhenGettingDepth(string[] input, int expectedResult)
        {
            NavigationService.GetDepth(input).Should().Be(expectedResult);
        }
        
        [TestCase(new[] {"forward 1", "up 1"}, 1)]
        [TestCase(new[] {"forward 5", "forward 1"}, 6)]
        [TestCase(new[] {"down 0", "up 1"}, 0)]
        [Test]
        public void WhenGettingLocation(string[] input, int expectedResult)
        {
            NavigationService.GetLocation(input).Should().Be(expectedResult);
        }
    }
}