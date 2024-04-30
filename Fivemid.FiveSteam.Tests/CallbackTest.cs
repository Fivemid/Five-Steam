using System.Threading;
using NUnit.Framework;
using Unity.Burst;
using Unity.Collections;

namespace Fivemid.FiveSteam.Tests {
    [BurstCompile]
    public unsafe class CallbackTest : SteamTestFixture {
        [Test]
        public void ManagedCallback() {
            bool managedListenerReceived = false;
            using FiveSteamAPI.CallbackListener managedListener =
                FiveSteamAPI.CallbackListener.Create<UserStatsReceived>(UserStatsReceived.IDENTIFIER, callback => {
                        Assert.AreEqual(Result.OK,              callback.eResult);
                        Assert.AreEqual(SteamUser.GetSteamID(), callback.steamIDUser);
                        managedListenerReceived = true;
                    }
                );
            
            Assert.IsTrue(SteamUserStats.RequestCurrentStats());
            for (int i = 0; i < 64; i++) {
                FiveSteamAPI.RunCallbacks();
                if (managedListenerReceived)
                    break;
                Thread.Sleep(1);
            }
            
            Assert.IsTrue(managedListenerReceived);
        }
        
        [Test]
        public void UnmanagedCallback() {
            UserStatsReceived* listenerReceived = AllocatorManager.Allocate<UserStatsReceived>(Allocator.Temp);
            listenerReceived->eResult = Result.None;
            using FiveSteamAPI.CallbackListener listener =
                FiveSteamAPI.CallbackListener.Create(
                    listenerReceived,
                    BurstCompiler.CompileFunctionPointer<FiveSteamAPI.CallbackListenerDelegate>(Listener)
                );
            
            Assert.IsTrue(SteamUserStats.RequestCurrentStats());
            for (int i = 0; i < 64; i++) {
                FiveSteamAPI.RunCallbacks();
                if (listenerReceived->eResult != Result.None)
                    break;
                Thread.Sleep(1);
            }
            
            Assert.AreEqual(Result.OK,              listenerReceived->eResult);
            Assert.AreEqual(SteamUser.GetSteamID(), listenerReceived->steamIDUser);
        }
        
        [BurstCompile]
        private static void Listener(ref FiveSteamAPI.Callback callback) {
            if (callback.id != UserStatsReceived.IDENTIFIER) return;
            callback.UserData<UserStatsReceived>() = callback.Data<UserStatsReceived>();
        }
    }
}