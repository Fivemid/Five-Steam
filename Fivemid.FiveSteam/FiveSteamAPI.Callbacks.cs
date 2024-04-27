using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

namespace Fivemid.FiveSteam {
    public static unsafe partial class FiveSteamAPI {
        private static readonly SharedStatic<NativeHashSet<CallbackListener>> listeners =
            SharedStatic<NativeHashSet<CallbackListener>>.GetOrCreate<SharedStaticListeners>();
        private static CallbackListenerDelegate managedListenerDelegate;
        
        private static void InitCallbacks() {
            SteamAPI.ManualDispatch_Init();
            
            listeners.Data = new(0, Allocator.Domain);
            
            managedListenerDelegate = ManagedListener;
            CallbackListener.Create(
                null,
                new FunctionPointer<CallbackListenerDelegate>(
                    Marshal.GetFunctionPointerForDelegate(managedListenerDelegate))
            );
        }
        
        private static void ShutdownCallbacks() {
            if (listeners.Data.IsCreated)
                listeners.Data.Dispose();
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
        
        private static void ManagedListener(ref Callback callback) {
            Debug.Log($"callback: {callback.id}");
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
            
            private CallbackListener(void* userData, FunctionPointer<CallbackListenerDelegate> functionPointer) {
                this.userData        = userData;
                this.functionPointer = functionPointer;
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
                FunctionPointer<CallbackListenerDelegate> functionPointer
            ) {
                CallbackListener callbackListener = new(userData, functionPointer);
                listeners.Data.Add(callbackListener);
                return callbackListener;
            }
            
            public void Dispose() {
                if (listeners.Data.IsCreated)
                    listeners.Data.Remove(this);
            }
        }
        
        private struct SharedStaticListeners { }
    }
}