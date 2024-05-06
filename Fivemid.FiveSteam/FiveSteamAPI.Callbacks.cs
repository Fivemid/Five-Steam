using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Fivemid.FiveSteam {
    public static unsafe partial class FiveSteamAPI {
        private static readonly SharedStatic<UnsafeHashSet<CallbackListener>> listeners =
            SharedStatic<UnsafeHashSet<CallbackListener>>.GetOrCreate<SharedStaticListeners>();
        
        private static void InitCallbacks() {
            SteamAPI.ManualDispatch_Init();
            
            listeners.Data = new(0, Allocator.Persistent);
        }
        
        private static void ShutdownCallbacks() {
            if (listeners.Data.IsCreated) {
                foreach (CallbackListener listener in listeners.Data)
                    listener.Dispose();
                listeners.Data.Dispose();
            }
            
            listeners.Data = default;
        }
        
        public static void RunCallbacks() {
            HSteamPipe pipe = SteamAPI.GetHSteamPipe();
            SteamAPI.ManualDispatch_RunFrame(pipe);
            
            CallbackMsg callbackMsg;
            while (SteamAPI.ManualDispatch_GetNextCallback(pipe, &callbackMsg)) {
                foreach (CallbackListener listener in listeners.Data) {
                    listener.Invoke(
                        (CallbackIdentifier)callbackMsg.m_iCallback,
                        callbackMsg.m_pubParam,
                        callbackMsg.m_cubParam
                    );
                }
                
                SteamAPI.ManualDispatch_FreeLastCallback(pipe);
            }
        }
        
        public delegate void CallbackListenerDelegate(ref Callback callback);
        
        public readonly struct Callback {
            public readonly void*              userData;
            public readonly CallbackIdentifier id;
            public readonly byte*              data;
            public readonly int                dataSize;
            
            public Callback(void* userData, CallbackIdentifier id, byte* data, int dataSize) {
                this.userData = userData;
                this.id       = id;
                this.data     = data;
                this.dataSize = dataSize;
            }
            
            public ref T UserData<T>() where T : unmanaged => ref *(T*)userData;
            public ref T Data<T>() where T : unmanaged     => ref *(T*)data;
        }
        
        public readonly struct CallbackListener : IEquatable<CallbackListener>, IDisposable {
            private readonly void*                                     userData;
            private readonly FunctionPointer<CallbackListenerDelegate> functionPointer;
            private readonly GCHandle                                  managedDelegateHandle;
            
            private CallbackListener(
                void*                                     userData,
                FunctionPointer<CallbackListenerDelegate> functionPointer,
                GCHandle                                  managedDelegateHandle
            ) {
                this.userData              = userData;
                this.functionPointer       = functionPointer;
                this.managedDelegateHandle = managedDelegateHandle;
            }
            
            public void Invoke(CallbackIdentifier id, byte* data, int dataSize) {
                Callback callback = new(userData, id, data, dataSize);
                functionPointer.Invoke(ref callback);
            }
            
            public bool Equals(CallbackListener other) =>
                userData              == other.userData
             && functionPointer.Value == other.functionPointer.Value;
            
            public override bool Equals(object obj) => obj is CallbackListener other && Equals(other);
            public override int  GetHashCode() => unchecked((int)userData * 397) ^ functionPointer.Value.GetHashCode();
            public static   bool operator ==(CallbackListener left, CallbackListener right) => left.Equals(right);
            public static   bool operator !=(CallbackListener left, CallbackListener right) => !left.Equals(right);
            
            public static CallbackListener Create(
                void*                                     userData,
                FunctionPointer<CallbackListenerDelegate> functionPointer,
                GCHandle                                  managedDelegateHandle = default
            ) {
                if (!Initialized)
                    throw new Exception("FiveSteamAPI is not initialized.");
                CallbackListener callbackListener = new(userData, functionPointer, managedDelegateHandle);
                listeners.Data.Add(callbackListener);
                return callbackListener;
            }
            
            public static CallbackListener Create(
                CallbackListenerDelegate @delegate
            ) =>
                Create(
                    null,
                    new FunctionPointer<CallbackListenerDelegate>(Marshal.GetFunctionPointerForDelegate(@delegate)),
                    GCHandle.Alloc(@delegate)
                );
            
            public static CallbackListener Create<T>(CallbackIdentifier identifier, Action<T> action)
                where T : unmanaged =>
                Create((ref Callback callback) => {
                    if (callback.id == identifier)
                        action(callback.Data<T>());
                });
            
            public void Dispose() {
                if (listeners.Data.IsCreated)
                    listeners.Data.Remove(this);
                if (managedDelegateHandle.IsAllocated)
                    managedDelegateHandle.Free();
            }
        }
        
        private struct SharedStaticListeners { }
    }
}