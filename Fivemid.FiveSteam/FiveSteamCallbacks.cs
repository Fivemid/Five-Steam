using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;

namespace Fivemid.FiveSteam {
    public unsafe struct FiveSteamCallbacks : IComponentData, IDisposable {
        private readonly AllocatorManager.AllocatorHandle       allocator;
        private          UnsafeHashMap<int, UnsafeAppendBuffer> buffers;
        
        public FiveSteamCallbacks(AllocatorManager.AllocatorHandle allocator) {
            this.allocator = allocator;
            buffers        = new UnsafeHashMap<int, UnsafeAppendBuffer>(0, allocator);
        }
        
        public void Add(CallbackIdentifier id, void* data, int size) {
            ref UnsafeAppendBuffer buffer = ref GetBuffer(ref this, id);
            buffer.Add(size);
            buffer.Add(data, size);
        }
        
        public CallbackEnumerable<T> Get<T>(CallbackIdentifier id)
            where T : unmanaged =>
            new() {
                reader = GetBuffer(ref this, id).AsReader()
            };
        
        public void Clear() {
            foreach (var entry in buffers) {
                entry.Value.Reset();
            }
        }
        
        private static unsafe ref UnsafeAppendBuffer GetBuffer(ref FiveSteamCallbacks self, in CallbackIdentifier id) {
            int key = (int)id;
            if (!self.buffers.ContainsKey(key)) {
                self.buffers.Add(key, new UnsafeAppendBuffer(0, sizeof(long), self.allocator));
            }
            
            return ref self.buffers.GetValueAsRef(UnsafeUtility.AsRef<int>(UnsafeUtility.AddressOf(ref key))); // TODO maybe not that clean
        }
        
        public void Dispose() {
            if (buffers.IsCreated) {
                foreach (var entry in buffers) {
                    entry.Value.Dispose();
                }
                
                buffers.Dispose();
            }
        }
        
        public unsafe struct CallbackEnumerable<T> where T : unmanaged {
            public UnsafeAppendBuffer.Reader reader;
            
            public Enumerator GetEnumerator() => new() {
                reader = reader
            };
            
            public struct Enumerator {
                public UnsafeAppendBuffer.Reader reader;
                
                private T current;
                
                public bool MoveNext() {
                    if (reader.EndOfBuffer) return false;
                    
                    int size = reader.ReadNext<int>();
                    current = default;
                    fixed (T* ptr = &current)
                        UnsafeUtility.MemCpy(ptr, reader.ReadNext(size), size);
                    
                    return true;
                }
                
                public ref readonly T Current {
                    get {
                        fixed (T* ptr = &current)
                            return ref *ptr;
                    }
                }
            }
        }
        
        public struct AnyCallback : IComponentData { }
    }
}