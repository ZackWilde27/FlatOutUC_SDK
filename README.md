# FlatOut Ultimate Carnage SDK

This C# library adds all the various structures, types, and helper functions to make modding FOUC with reloaded easier, based on my current understanding of the game

As I continue to decompile the game, the SDK is subject to change, though I'm only adding things I'm sure about so it should only ever be additions

I've tried to make the interface similar to [Sewer's FlatOut 2 SDK](https://github.com/Sewer56/FlatOut2.SDK), so people that have used it should feel right at home

<br>

To get started, add these `using` statements to the top
```c#
using FlatOutUC_SDK; // Gives you access to SDK, Info, Helpers, and CheatCodeManager
using FlatOutUC_SDK.Structs; // If you need to access any of the structs
using FlatOutUC_SDK.Enums; // If you need to access any of the enums
using FlatOutUC_SDK.Functions; // Contains all the delegates for helpers, it's unlikely you'll need this but it's there
```

<br>

Then call Init on the SDK
```c#
SDK.Init(_hooks!);
```

<br>

Theres a helper for adding cheat codes, and a helper for getting a function called per-frame, just like 2's SDK
```c#
private static void PerFrame()
{
}

private static void MyCheatCode(PlayerProfile* profile)
{
  profile->Money = 999999;
}

SDK.Init(_hooks!);
Helpers.HookPerFrame(PerFrame);
CheatCodeManager.AddCheatCode("TEST", MyCheatCode);
```

<br>

Lastly there's an Info class, which has sub-classes to categorize the API functions

The only one I've got ported right now is GetAllPlayers() under Info.Race
```c#
// You can't have a span of Player* so they are stored as nints, you'll have to cast them
Span<nint> players = Info.Race.GetAllPlayers();

// I also added a few others
Player* player = Info.Race.GetPlayer(0);
int numPlayers = Info.Race.GetNumPlayers();
```
