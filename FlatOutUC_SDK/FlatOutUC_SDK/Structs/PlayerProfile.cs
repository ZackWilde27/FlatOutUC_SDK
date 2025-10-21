using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlatOutUC_SDK.Structs;

[StructLayout(LayoutKind.Explicit)]
public class PlayerProfile
{
    [FieldOffset(0x12B4)]
    public uint Money;
}
