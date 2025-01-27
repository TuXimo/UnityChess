using System.Threading.Tasks;
using UnityChess.Core.UnityChessLib.src.Base;

namespace Core.UnityChess.Game {
	public interface IUCIEngine {
		void Start();
		
		void ShutDown();
		
		Task SetupNewGame(global::UnityChess.Core.UnityChessLib.src.Base.Game game);
		
		Task<Movement> GetBestMove(int timeoutMS);
	}
}