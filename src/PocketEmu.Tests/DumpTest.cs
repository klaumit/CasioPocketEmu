using System.IO;
using Xunit;
using static PoViEmu.Tests.DumpTest;

namespace PocketEmu.Tests
{
    public class DumpTest
    {
        [Theory]
        [InlineData("sscxp_400")]
        [InlineData("sscxp_600")]
        public void ShouldReadG501(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "G501");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("sscxp_460")]
        [InlineData("Ultra_Sx60")]
        public void ShouldReadG500(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "G500");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("s450_kbl")]
        [InlineData("s250")]
        [InlineData("ssc_pvos")]
        [InlineData("sscxp_250")]
        public void ShouldReadZ481(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "Z481");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("250X_101")]
        [InlineData("250X_111")]
        [InlineData("250x_rus")]
        [InlineData("450X_101")]
        [InlineData("450X_111")]
        [InlineData("450x_rus")]
        [InlineData("sscxp_250x")]
        [InlineData("sscxp_450x")]
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