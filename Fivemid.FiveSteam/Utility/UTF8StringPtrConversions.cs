using Unity.Collections;

namespace Fivemid.FiveSteam {
    public static unsafe class UTF8StringPtrConversions {
        public static UTF8StringPtr AsUTF8StringPtr<T>(this T utf8Bytes) where T : unmanaged, IUTF8Bytes =>
            new() {
                value = utf8Bytes.GetUnsafePtr()
            };
        
        public static FixedString128Bytes AsFixedString32Bytes<T>(this T utf8Bytes)
            where T : unmanaged, IUTF8Bytes =>
            utf8Bytes.AsFixedString<T, FixedString32Bytes>();
        
        public static FixedString64Bytes AsFixedString64Bytes<T>(this T utf8Bytes)
            where T : unmanaged, IUTF8Bytes =>
            utf8Bytes.AsFixedString<T, FixedString64Bytes>();
        
        public static FixedString128Bytes AsFixedString128Bytes<T>(this T utf8Bytes)
            where T : unmanaged, IUTF8Bytes =>
            utf8Bytes.AsFixedString<T, FixedString128Bytes>();
        
        public static FixedString512Bytes AsFixedString512Bytes<T>(this T utf8Bytes)
            where T : unmanaged, IUTF8Bytes =>
            utf8Bytes.AsFixedString<T, FixedString512Bytes>();
        
        public static FixedString4096Bytes AsFixedString4096Bytes<T>(this T utf8Bytes)
            where T : unmanaged, IUTF8Bytes =>
            utf8Bytes.AsFixedString<T, FixedString4096Bytes>();
        
        private static TFixedString AsFixedString<TUTF8Bytes, TFixedString>(this TUTF8Bytes utf8Bytes)
            where TUTF8Bytes : unmanaged, IUTF8Bytes
            where TFixedString : unmanaged, INativeList<byte> {
            TFixedString fixedString  = default;
            byte*        utf8BytesPtr = utf8Bytes.GetUnsafePtr();
            for (int i = 0; i < fixedString.Capacity; i++) {
                byte b = utf8BytesPtr[i];
                if (b == 0)
                    break;
                
                fixedString[fixedString.Length++] = b;
            }
            
            return fixedString;
        }
    }
}