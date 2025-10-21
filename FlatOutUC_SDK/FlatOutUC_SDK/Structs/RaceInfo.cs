using FlatOutUC_SDK.Enums;
using System.Runtime.InteropServices;

namespace FlatOutUC_SDK.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct RaceInfo
    {
        public static readonly RaceInfo** Instance = (RaceInfo**)0x09298FAC;

        [FieldOffset(0x54)]
        public SigninState SigninState;

        [FieldOffset(0x7C)]
        public BOOL AutosaveEnabled;

        [FieldOffset(0x2820)]
        public PlayerHost* PlayerHost;

        [FieldOffset(0x287C)]
        public BOOL Started;
    }
}
