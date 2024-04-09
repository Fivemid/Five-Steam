using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>InputMotionData_t</summary>
    public unsafe struct InputMotionData
    {
        /// <summary>float rotQuatX</summary>
        public float rotQuatX;
        /// <summary>float rotQuatY</summary>
        public float rotQuatY;
        /// <summary>float rotQuatZ</summary>
        public float rotQuatZ;
        /// <summary>float rotQuatW</summary>
        public float rotQuatW;
        /// <summary>float posAccelX</summary>
        public float posAccelX;
        /// <summary>float posAccelY</summary>
        public float posAccelY;
        /// <summary>float posAccelZ</summary>
        public float posAccelZ;
        /// <summary>float rotVelX</summary>
        public float rotVelX;
        /// <summary>float rotVelY</summary>
        public float rotVelY;
        /// <summary>float rotVelZ</summary>
        public float rotVelZ;
    }
}