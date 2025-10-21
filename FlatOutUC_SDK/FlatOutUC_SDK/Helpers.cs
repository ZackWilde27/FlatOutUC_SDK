using FlatOutUC_SDK.Functions;
using Reloaded.Hooks.Definitions;

namespace FlatOutUC_SDK;

public static class Helpers
{
    private static VoidFunction? PerFrame = null;

    private static IHook<RenderRacePtr> RenderRaceHook;

    private static void NewRenderRace(uint param_1, uint param_2)
    {
        PerFrame?.Invoke();
        RenderRaceHook.OriginalFunction(param_1, param_2);
    }

    public static void HookPerFrame(VoidFunction toBeCalledPerFrame)
    {
        PerFrame = toBeCalledPerFrame;
        RenderRaceHook = SDK._hooks!.CreateHook<RenderRacePtr>(NewRenderRace, 0x0048AAF0).Activate();
    }
}