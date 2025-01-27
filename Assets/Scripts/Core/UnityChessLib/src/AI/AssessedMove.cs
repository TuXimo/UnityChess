using UnityChess.Core.UnityChessLib.src.Base;

namespace UnityChess.Core.UnityChessLib.src.AI {
	public class AssessedMove {

		public AssessedMove(Movement move, int value) {
			Move = move;
			Value = value;
		}

		public Movement Move { get; set; }
		public int Value { get; set; }
	}
}