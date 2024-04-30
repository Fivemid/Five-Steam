using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Represents the current state of a device's motion sensor(s).<br />
    /// <br />
    /// <b>NOTE:</b> For rotQuatX/rotQuatY/rotQuatZ/rotQuatW, the inertial measurement unit on the controller will create a quaternion based on fusing the gyro and the accelerometer. This value is the absolute orientation of the controller, but it will drift on the yaw axis.<br />
    /// <br />
    /// Positional acceleration is reported as an interpolated value between INT16_MIN and INT16_MAX where the extents are clamped to ±2G (1G = 9.80665 m/s<sup>2</sup>).<br />
    /// <br />
    /// Angular velocity is reported as an interpolated value between INT16_MIN and INT16_MAX where the extents are clamped to ±2000 degrees per second.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public unsafe struct InputMotionData
    {
        /// <summary>Sensor-fused absolute rotation (will drift in heading), x axis</summary>
        public float rotQuatX;
        /// <summary>Sensor-fused absolute rotation (will drift in heading), y axis</summary>
        public float rotQuatY;
        /// <summary>Sensor-fused absolute rotation (will drift in heading), z axis</summary>
        public float rotQuatZ;
        /// <summary>Sensor-fused absolute rotation (will drift in heading), w axis</summary>
        public float rotQuatW;
        /// <summary>Positional acceleration, x axis</summary>
        public float posAccelX;
        /// <summary>Positional acceleration, y axis</summary>
        public float posAccelY;
        /// <summary>Positional acceleration, z axis</summary>
        public float posAccelZ;
        /// <summary>Angular velocity, x axis</summary>
        public float rotVelX;
        /// <summary>Angular velocity, y axis</summary>
        public float rotVelY;
        /// <summary>Angular velocity, z axis</summary>
        public float rotVelZ;
    }
}