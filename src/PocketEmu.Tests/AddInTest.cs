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
        public void ShouldReadZ486(string fileName)
        {
            var dir = Path.Combine("Resources", "Addins", "Z486");
            DoShouldRead(dir, fileName);
        }
    }
}