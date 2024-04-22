using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    public enum WorkshopFileAction : int
    {
        /// <summary>The user has played with or on this item. (e.g. Loaded a weapon or level.)</summary>
        Played = 0,
        /// <summary>The user has completed this item. (e.g. Got to the end of a linear map.)</summary>
        Completed = 1
    }
}