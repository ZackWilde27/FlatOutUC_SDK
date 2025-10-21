using FlatOutUC_SDK.Functions;
using Reloaded.Hooks.Definitions;
using FlatOutUC_SDK.Structs;

namespace FlatOutUC_SDK;

struct CheatCode
{
    public string code;
    public CheatCodeCallback callback;

    public CheatCode(string code, CheatCodeCallback onActivation)
    {
        this.code = code;
        this.callback = onActivation;
    }
}


public class CheatCodeManager
{
    private static IHook<CheckCheatCodePtr>? CheatCodeHook = null;

    private static List<CheatCode> NewCheatCodes = new();

    private static unsafe BOOL NewCheckCheatCodes(PlayerProfile* profile_EAX, string code)
    {
        foreach (CheatCode newCode in NewCheatCodes)
        {
            if (newCode.code == code)
            {
                newCode.callback(profile_EAX);
                return true;
            }
        }

        return CheatCodeHook!.OriginalFunction(profile_EAX, code);
    }

    private static unsafe void ExampleCheatCode(PlayerProfile* profile)
    {
        profile->Money = 272727;
    }

    /// <summary>
    /// Adds a new cheat code, automatically hooks the cheat code check if this is the first call
    /// </summary>
    /// <param name="code">The code to check for, there's no on-screen keyboard so the case does not matter</param>
    /// <param name="onActivation">The function to be called when the cheat is entered, it takes a PlayerProfile* and returns void</param>
    public static unsafe void AddCheatCode(string code, CheatCodeCallback onActivation)
    {
        if (CheatCodeHook == null)
        {
            CheatCodeHook = SDK._hooks.CreateHook<CheckCheatCodePtr>(NewCheckCheatCodes, 0x00485E20).Activate();
            AddCheatCode("ZACK", ExampleCheatCode);
        }

        NewCheatCodes.Add(new(code, onActivation));
    }
}
