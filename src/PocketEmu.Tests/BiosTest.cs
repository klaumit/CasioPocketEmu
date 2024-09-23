using System.IO;
using Xunit;
using static PoViEmu.Tests.DumpCheck;

namespace PocketEmu.Tests
{
    public class BiosTest
    {
        [Theory]
        [InlineData("G500", "BIOS500")]
        [InlineData("G500", "BIOS_sim")]
        [InlineData("G501", "BIOS400")]
        [InlineData("G501", "BIOS600")]
        [InlineData("G501", "BIOS_sim")]
        [InlineData("Z481", "BIOS450")]
        [InlineData("Z481", "BIOS_sim")]
        [InlineData("Z486", "BIOS250X")]
        [InlineData("Z486", "BIOS450X")]
        [InlineData("Z488", "BIOS750")]
        [InlineData("Z488", "BIOS_sim0")]
        [InlineData("Z488", "BIOS_sim1")]
        public void ShouldRead(string model, string fileName)
        {
            var dir = Path.Combine("Resources", "Bios", model);
            DoShouldRead(dir, fileName, ext: ".dat");
        }
    }
}