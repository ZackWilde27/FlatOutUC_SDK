using System.Runtime.InteropServices;

namespace FlatOutUC_SDK.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Player
    {
        [FieldOffset(0x294)]
        public Car* Car;
    }
}
