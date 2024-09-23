using System.IO;
using Xunit;
using static PoViEmu.Tests.DumpCheck;

namespace PocketEmu.Tests
{
    public class DumpTest
    {
        [Theory]
        [InlineData("PVosUA_S400")]
        [InlineData("PVS400P")]
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
        [InlineData("belka")]
        [InlineData("pvos_plus_60")]
        [InlineData("PVosUA_S460")]
        [InlineData("pvos_x60_orig")]
        [InlineData("pvos_x60_ua")]
        [InlineData("ssc_pvos_mod_x60")]
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
        [InlineData("PVosUA_S250")]
        [InlineData("pvs450r")]
        [InlineData("pvsrus")]
        [InlineData("s450_apps_eng")]
        [InlineData("s450_menu_apps_eng")]
        [InlineData("s450_menu_eng")]
        [InlineData("ssc_apps")]
        [InlineData("ssc_menu")]
        [InlineData("ssc_menu_apps")]
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
        [InlineData("pv450xrus")]
        [InlineData("pv250xrus")]
        [InlineData("PVosUA_450X")]
        public void ShouldReadZ486(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "Z486");
            DoShouldRead(dir, fileName);
        }

        [Theory]
        [InlineData("750plus")]
        [InlineData("750up120")]
        [InlineData("sscxp_750")]
        [InlineData("PVosUA_750")]
        public void ShouldReadZ488(string fileName)
        {
            var dir = Path.Combine("Resources", "Dumps", "Z488");
            DoShouldRead(dir, fileName);
        }
    }
}
