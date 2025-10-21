using FlatOutUC_SDK.Structs;
using Reloaded.Hooks.Definitions.X86;
using static Reloaded.Hooks.Definitions.X86.FunctionAttribute;

namespace FlatOutUC_SDK.Functions
{
    public unsafe delegate void CheatCodeCallback(PlayerProfile* profile);

    [Function(new Register[] { Register.eax }, Register.eax, StackCleanup.Callee)]
    public unsafe delegate BOOL CheckCheatCodePtr(PlayerProfile* profile_EAX, string code);
}

