using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;

namespace Fivemid.FiveSteam {
    [UpdateInGroup(typeof(InitializationSystemGroup))]
    public unsafe partial struct FiveSteamCallbackSystem : ISystem {
        private FiveSteamAPI.CallbackListener callbackListener;
        private UnsafeAppendBuffer*           callbackBuffer;
        
        [BurstCompile]
        public void OnCreate(ref SystemState state) {
            callbackBuffer  = AllocatorManager.Allocate<UnsafeAppendBuffer>(Allocator.Persistent);
            *callbackBuffer = new UnsafeAppendBuffer(0, sizeof(int), Allocator.Persistent);
            callbackListener = FiveSteamAPI.CallbackListener.Create(
                callbackBuffer,
                BurstCompiler.CompileFunctionPointer<FiveSteamAPI.CallbackListenerDelegate>(Callback));
            {
                Entity entity = state.EntityManager.CreateSingleton(new FiveSteamCallbacks(Allocator.Persistent));
                state.EntityManager.AddComponent<FiveSteamCallbacks.AnyCallback>(entity);
            }
        }
        
        [BurstCompile]
        public void OnUpdate(ref SystemState state) {
            ref FiveSteamCallbacks fiveSteamCallbacks = ref SystemAPI.GetSingletonRW<FiveSteamCallbacks>().ValueRW;
            
            fiveSteamCallbacks.Clear();
            bool anyCallback = false;
            
            UnsafeAppendBuffer.Reader reader = callbackBuffer->AsReader();
            
            while (!reader.EndOfBuffer) {
                CallbackIdentifier id       = reader.ReadNext<CallbackIdentifier>();
                int                dataSize = reader.ReadNext<int>();
                void*              data     = reader.ReadNext(dataSize);
                
                fiveSteamCallbacks.Add(id, data, dataSize);
                anyCallback = true;
            }
            
            callbackBuffer->Reset();
            
            SystemAPI.SetComponentEnabled<FiveSteamCallbacks.AnyCallback>(
                SystemAPI.GetSingletonEntity<FiveSteamCallbacks>(), anyCallback);
        }
        
        public void OnDestroy(ref SystemState state) {
            callbackListener.Dispose();
            callbackBuffer->Dispose();
            AllocatorManager.Free(Allocator.Persistent, callbackBuffer);
            
            ref FiveSteamCallbacks fiveSteamCallbacks = ref SystemAPI.GetSingletonRW<FiveSteamCallbacks>().ValueRW;
            fiveSteamCallbacks.Dispose();
            state.EntityManager.DestroyEntity(SystemAPI.GetSingletonEntity<FiveSteamCallbacks>());
        }
        
        [BurstCompile]
        private static void Callback(ref FiveSteamAPI.Callback callback) {
            ref UnsafeAppendBuffer callbackBuffer = ref callback.UserData<UnsafeAppendBuffer>();
            callbackBuffer.Add(callback.id);
            callbackBuffer.Add(callback.dataSize);
            callbackBuffer.Add(callback.data, callback.dataSize);
        }
    }
}