using System.IO;
using Xunit;
using static PoViEmu.Tests.AddInCheck;

namespace PocketEmu.Tests
{
    public class AddInTest
    {
        [Theory]
        [InlineData("CalcRus")]
        [InlineData("GetOS2_1.2")]
        [InlineData("GetOS_1.2")]
        [InlineData("Puzzle_1.0")]
        [InlineData("Sample_1.0")]
        [InlineData("SSC-Bench_1.1")]
        [InlineData("SSC-Dict_1.1")]
        [InlineData("SSC-Dict_1.25")]
        [InlineData("SSC-TalkTime_1.0")]
        public void ShouldReadZ486(string fileName)
        {
            var dir = Path.Combine("Resources", "Addins", "Z486");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("Dumper_1.07")]
        [InlineData("jgirls3_1.0")]
        [InlineData("Mystrpg_1.0")]
        [InlineData("Puzzle_1.0")]
        [InlineData("PVMerlin3pl_3.1")]
        [InlineData("PVMerlin4_4.01")]
        [InlineData("Sample_1.0")]
        public void ShouldReadZ488(string fileName)
        {
            var dir = Path.Combine("Resources", "Addins", "Z488");
            DoShouldRead(dir, fileName);
        }
    }
}