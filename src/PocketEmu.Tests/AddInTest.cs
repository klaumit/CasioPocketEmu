using System.IO;
using Xunit;
using static PoViEmu.Tests.AddInTest;

namespace PocketEmu.Tests
{
    public class AddInTest
    {
        [Theory]
        [InlineData("GetOS2_1.2")]
        [InlineData("GetOS_1.2")]
        [InlineData("Puzzle_1.0")]
        [InlineData("Sample_1.0")]
        public void ShouldReadZ486(string fileName)
        {
            var dir = Path.Combine("Resources", "Addins", "Z486");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("Puzzle_1.0")]
        public void ShouldReadZ488(string fileName)
        {
            var dir = Path.Combine("Resources", "Addins", "Z488");
            DoShouldRead(dir, fileName);
        }
    }
}