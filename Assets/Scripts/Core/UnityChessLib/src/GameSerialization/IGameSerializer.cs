using UnityChess.Core.UnityChessLib.src.Base;

namespace UnityChess.Core.UnityChessLib.src.GameSerialization {
	public interface IGameSerializer {
		string Serialize(Game game);

		Game Deserialize(string gameString);
	}
}