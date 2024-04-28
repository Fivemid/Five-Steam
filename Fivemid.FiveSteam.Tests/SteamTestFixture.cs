using NUnit.Framework;

namespace Fivemid.FiveSteam.Tests {
    [TestFixture]
    public class SteamTestFixture {
        [OneTimeSetUp]
        public void SteamSetUp() {
            FiveSteamAPI.Init(480);
        }
        
        [OneTimeTearDown]
        public void SteamTearDown() {
            FiveSteamAPI.Shutdown();
        }
    }
}