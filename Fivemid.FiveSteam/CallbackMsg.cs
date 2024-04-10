namespace Fivemid.FiveSteam {
    public unsafe struct CallbackMsg {
        /// <summary>
        /// Specific user to whom this callback applies.
        /// </summary>
        private HSteamUser m_hSteamUser;
        /// <summary>
        /// Callback identifier.  (Corresponds to the k_iCallback enum in the callback structure.)
        /// </summary>
        private int m_iCallback;
        /// <summary>
        /// Points to the callback structure
        /// </summary>
        private byte* m_pubParam;
        /// <summary>
        /// Size of the data pointed to by m_pubParam
        /// </summary>
        private int m_cubParam;
    }
}