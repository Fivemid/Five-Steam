using System;
using Unity.Burst;
using Unity.Collections;

namespace Fivemid.FiveSteam {
    public static partial class FiveSteamAPI {
        private static NativeHashSet<CallbackListener> listeners;
        
        public static void RunCallbacks() {
            // TODO implement
        }
        
        public unsafe delegate void CallbackListenerDelegate(void* userData, int type, void* data);
        
        public readonly unsafe struct CallbackListener : IEquatable<CallbackListener>, IDisposable {
            private readonly void*                                     userData;
            private readonly FunctionPointer<CallbackListenerDelegate> functionPointer;
            
            private CallbackListener(void* userData, FunctionPointer<CallbackListenerDelegate> functionPointer) {
                this.userData        = userData;
                this.functionPointer = functionPointer;
            }
            
            public void Invoke(int type, void* data) =>
                functionPointer.Invoke(userData, type, data);
            
            public bool Equals(CallbackListener other) =>
                userData == other.userData
             && functionPointer.Value.Equals(other.functionPointer.Value);
            
            public override bool Equals(object obj) => obj is CallbackListener other && Equals(other);
            public override int  GetHashCode() => unchecked((int)userData * 397) ^ functionPointer.Value.GetHashCode();
            public static   bool operator ==(CallbackListener left, CallbackListener right) => left.Equals(right);
            public static   bool operator !=(CallbackListener left, CallbackListener right) => !left.Equals(right);
            
            public static CallbackListener Create(
                void*                                     userData,
                FunctionPointer<CallbackListenerDelegate> functionPointer
            ) {
                CallbackListener callbackListener = new(userData, functionPointer);
                listeners.Add(callbackListener);
                return callbackListener;
            }
            
            public void Dispose() {
                listeners.Remove(this);
            }
        }
    }
}