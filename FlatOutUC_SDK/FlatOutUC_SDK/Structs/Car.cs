using System.Numerics;
using System.Runtime.InteropServices;

namespace FlatOutUC_SDK.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Car
    {
        [FieldOffset(0x1C0)]
        public Matrix4x4 WorldMatrix;

        /// <summary>
        /// The position is just the 4th row of the WorldMatrix
        /// </summary>
        [FieldOffset(0x1F0)]
        public Vector4 Position;

        [FieldOffset(0x280)]
        public Quaternion Rotation;
        [FieldOffset(0x290)]
        public Vector4 Velocity;
        [FieldOffset(0x2A0)]
        public Vector4 RotationalVelocity;

        /// <summary>
        /// Whether or not the driver has been ejected out of their car
        /// </summary>
        [FieldOffset(0x3590)]
        public BOOL RagdollState;

        /// <summary>
        /// Points to the owning player, for things like showing the portrait when you get near
        /// </summary>
        [FieldOffset(0x469C)]
        public Player* Owner;

        /// <summary>
        /// Total damage, from 0-1
        /// </summary>
        [FieldOffset(0x7AB8)]
        public float Damage;

        public readonly bool IsWrecked()
        {
            return Damage >= 1.0;
        }
    }
}
