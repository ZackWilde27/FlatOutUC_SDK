using Reloaded.Hooks.Definitions.X86;

namespace FlatOutUC_SDK.Functions
{
    [Function(CallingConventions.Stdcall)]
    delegate void RenderRacePtr(uint param_1, uint param_2);

    /// <summary>
    /// Delegate for a function that takes no parameters and returns void
    /// </summary>
    public delegate void VoidFunction();
}
