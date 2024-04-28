using NUnit.Framework;

namespace Fivemid.FiveSteam.Tests {
    public class SimpleTest : SteamTestFixture {
        [Test]
        public void Initialized() {
            Assert.IsTrue(FiveSteamAPI.Initialized);
        }
        
        [Test]
        public void AppId() {
            Assert.AreEqual(480U, FiveSteamAPI.AppId.value);
            Assert.AreEqual(480U, SteamUtils.GetAppID());
        }
    }
}