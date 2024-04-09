using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
	public unsafe struct UTF8StringPtr
	{
		public char* value;

		public override string ToString() =>
			Marshal.PtrToStringUTF8( (IntPtr)value );
	}
}
