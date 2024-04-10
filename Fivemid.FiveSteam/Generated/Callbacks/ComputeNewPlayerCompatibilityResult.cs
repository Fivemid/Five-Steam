using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ComputeNewPlayerCompatibilityResult_t</summary>
    public unsafe struct ComputeNewPlayerCompatibilityResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int m_cPlayersThatDontLikeCandidate</summary>
        public int cPlayersThatDontLikeCandidate;
        /// <summary>int m_cPlayersThatCandidateDoesntLike</summary>
        public int cPlayersThatCandidateDoesntLike;
        /// <summary>int m_cClanPlayersThatDontLikeCandidate</summary>
        public int cClanPlayersThatDontLikeCandidate;
        /// <summary>CSteamID m_SteamIDCandidate</summary>
        public SteamId SteamIDCandidate;
    }
}