using Unity.Collections;

namespace Fivemid.FiveSteam {
    public static unsafe class UTF8StringPtrConversions {
        public static UTF8StringPtr AsUTF8StringPtr<T>(this ref T utf8Bytes) where T : unmanaged, IUTF8Bytes =>
            new() {
                value = (char*)utf8Bytes.GetUnsafePtr()
            };
    }
}