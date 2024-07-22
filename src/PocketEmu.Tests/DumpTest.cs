using System.IO;
using Xunit;
using static PoViEmu.Tests.DumpTest;

namespace PocketEmu.Tests
{
    public class DumpTest
    {
        [Theory]
        [InlineData("PVOS_ULTRA_Sx60")]
        public void ShouldReadG500(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "G500");
            DoShouldRead(dir, fileName);
        }
    }
}