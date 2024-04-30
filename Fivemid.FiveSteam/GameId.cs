using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
	public struct GameId
	{
		public ulong value; // TODO check what this is
	}
}
