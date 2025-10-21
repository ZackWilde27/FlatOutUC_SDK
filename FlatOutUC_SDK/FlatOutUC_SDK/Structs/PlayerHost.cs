using System.Runtime.InteropServices;

namespace FlatOutUC_SDK.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct PlayerHost
    {
        [FieldOffset(0x14)]
        public Player** Players;

        [FieldOffset(0x18)]
        public Player** LastPlayer;

        public readonly int GetNumPlayers()
        {
            return (int)(((nint)LastPlayer - (nint)Players) >> 2);
        }
    }
}
