using System.IO;
using Xunit;
using static PoViEmu.Tests.DumpTest;

namespace PocketEmu.Tests
{
    public class BiosTest
    {
        [Theory]
        [InlineData("G500", "BIOS500")]
        [InlineData("G501", "BIOS400")]
        [InlineData("G501", "BIOS600")]
        [InlineData("Z481", "BIOS450")]
        [InlineData("Z486", "BIOS250X")]
        [InlineData("Z486", "BIOS450X")]
        [InlineData("Z488", "BIOS750")]
        public void ShouldRead(string model, string fileName)
        {
            var dir = Path.Combine("Resources", "Bios", model);
            DoShouldRead(dir, fileName, ext: ".dat");
        }
    }
}