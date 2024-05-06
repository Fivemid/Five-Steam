using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;

namespace Fivemid.FiveSteam {
    [UpdateInGroup(typeof(InitializationSystemGroup))]
    public unsafe partial struct FiveSteamCallbackSystem : ISystem, ISystemStartStop {
        private FiveSteamAPI.CallbackListener callbackListener;
        private UnsafeAppendBuffer*           callbackBuffer;
        
        [BurstCompile]
        public void OnCreate(ref SystemState state) {
            callbackBuffer  = AllocatorManager.Allocate<UnsafeAppendBuffer>(Allocator.Persistent);
            *callbackBuffer = new UnsafeAppendBuffer(0, sizeof(int), Allocator.Persistent);
            
            state.EntityManager.AddComponentData(state.SystemHandle, new FiveSteamCallbacks(Allocator.Persistent));
        }
        
        public void OnDestroy(ref SystemState state) {
            callbackBuffer->Dispose();
            AllocatorManager.Free(Allocator.Persistent, callbackBuffer);
            
            ref FiveSteamCallbacks fiveSteamCallbacks =
                ref state.EntityManager.GetComponentDataRW<FiveSteamCallbacks>(state.SystemHandle).ValueRW;
            fiveSteamCallbacks.Dispose();
            state.EntityManager.RemoveComponent<FiveSteamCallbacks>(state.SystemHandle);
        }
        
        public void OnStartRunning(ref SystemState state) {
            callbackListener = FiveSteamAPI.CallbackListener.Create(
                callbackBuffer,
                BurstCompiler.CompileFunctionPointer<FiveSteamAPI.CallbackListenerDelegate>(Callback));
        }
        
        public void OnStopRunning(ref SystemState state) {
            callbackListener.Dispose();
        }
        
        [BurstCompile]
        public void OnUpdate(ref SystemState state) {
            ref FiveSteamCallbacks fiveSteamCallbacks =
                ref state.EntityManager.GetComponentDataRW<FiveSteamCallbacks>(state.SystemHandle).ValueRW;
            
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
            
            {
                if (state.EntityManager.HasComponent<FiveSteamCallbacks.AnyCallback>(state.SystemHandle)
                 != anyCallback
                   ) {
                    if (anyCallback) {
                        state.EntityManager.AddComponent<FiveSteamCallbacks.AnyCallback>(state.SystemHandle);
                    } else {
                        state.EntityManager.RemoveComponent<FiveSteamCallbacks.AnyCallback>(state.SystemHandle);
                    }
                }
            }
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