using Reloaded.Hooks.Definitions;

namespace FlatOutUC_SDK;

public class SDK
{
    public static IReloadedHooks? _hooks;

    public static void Init(IReloadedHooks hooks)
    {
        _hooks = hooks;
    }
}

