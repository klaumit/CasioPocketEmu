using System.IO;
using Xunit;
using static PoViEmu.Tests.DumpTest;

namespace PocketEmu.Tests
{
    public class DumpTest
    {
        [Theory]
        [InlineData("Ultra_Sx60")]
        public void ShouldReadG500(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "G500");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("s250")]
        public void ShouldReadZ481(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "Z481");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("250X_101")]
        [InlineData("250X_111")]
        [InlineData("450X_101")]
        [InlineData("450X_111")]
        public void ShouldReadZ486(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "Z486");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("750plus")]
        [InlineData("750up120")]
        [InlineData("sscxp_750")]
        public void ShouldReadZ488(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "Z488");
            DoShouldRead(dir, fileName);
        }
    }
}