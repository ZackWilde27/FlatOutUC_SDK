using FlatOutUC_SDK.Structs;

namespace FlatOutUC_SDK;

public class Info
{
    public class Race
    {
        public static unsafe Span<nint> GetAllPlayers()
        {
            var racePtr = *RaceInfo.Instance;
            if (racePtr == null || racePtr->PlayerHost == null) return new();

            return new(racePtr->PlayerHost->Players, racePtr->PlayerHost->GetNumPlayers());
        }

        public static unsafe Player* GetPlayer(int index)
        {
            var racePtr = *RaceInfo.Instance;
            if (racePtr == null || racePtr->PlayerHost == null) return null;

            return racePtr->PlayerHost->Players[index];
        }

        public static unsafe int GetNumPlayers()
        {
            var racePtr = *RaceInfo.Instance;
            if (racePtr == null || racePtr->PlayerHost == null) return 0;

            return racePtr->PlayerHost->GetNumPlayers();
        }
    }
}
