using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Common.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly FileService _fileService = new FileService();
        private List<string> _result;

        [SetUp]
        public void Setup()
        {
            _result = _fileService.ReadFile("..//..//..//InputFiles//TestFile.UnitTest.txt").ToList();
        }
        
        [Test]
        public void Should_read_from_file()
        {
            _result.Should().NotBeEmpty();
        }

        [Test]
        public void Should_not_read_commented_block()
        {
            _result.Where(row => row.Contains("comment")).Should().BeEmpty();
        }

        [Test]
        public void Should_read_regular_text()
        {
            _result.Should().Contain("This is a regular text line");
        }

        [Test]
        public void Should_read_special_characters()
        {
            _result.Should().Contain(@"!""#€%&/()=?`^^'-.,<>©@£$∞§|[]≈±´¡”¥¢‰}≠¿`^’Æ™æ~§°©•");
        }

        [Test]
        public void Should_read_all_non_commented_rows()
        {
            _result.Count.Should().Be(7);
        }
    }
}