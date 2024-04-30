using System.Runtime.InteropServices;
using NUnit.Framework;
using Unity.Collections.LowLevel.Unsafe;

namespace Fivemid.FiveSteam.Tests {
    public class StructLayoutTest {
        [Test]
        public void Pack1Align() {
            Assert.AreEqual(1, UnsafeUtility.AlignOf<SteamId>());
            Assert.AreEqual(1, UnsafeUtility.AlignOf<GameId>());
        }
        
        [Test]
        public void SizeOf() {
            Assert.AreEqual(
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
                32,
#elif UNITY_STANDALONE_LINUX || UNITY_EDITOR_LINUX
                24,
#endif
                UnsafeUtility.SizeOf<ValvePackingSentinel>()
            );
        }
        
        [Test]
        public void Offsets() {
            Assert.AreEqual(
                12,
                UnsafeUtility.GetFieldOffset(
                    typeof(UserStatsReceived).GetField(nameof(UserStatsReceived.steamIDUser))
                )
            );
        }
        
        private struct ValvePackingSentinel {
            uint   m_u32;
            ulong  m_u64;
            ushort m_u16;
            double m_d;
        }
    }
}