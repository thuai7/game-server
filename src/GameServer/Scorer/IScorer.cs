using GameServer.Game;

namespace GameServer.Scorer;

public interface IScorer
{
    Dictionary<IPlayer, int> RankOfPlayers { get; }
}
