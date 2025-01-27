using System.Collections.Generic;
using UnityChess.Core.UnityChessLib.src.Base;
using UnityChess.Core.UnityChessLib.src.GameSerialization;

namespace UnityChess.Core.UnityChessLib.src.Pieces {
	public class Knight : Piece<Knight> {
		public Knight() : base(Side.None) {}
		public Knight(Side owner) : base(owner) {}

		public override Dictionary<(Square, Square), Movement> CalculateLegalMoves(
			Board board,
			GameConditions gameConditions,
			Square position
		) {
			Dictionary<(Square, Square), Movement> result = null;
			
			foreach (Square offset in SquareUtil.KnightOffsets) {
				Movement testMove = new Movement(position, position + offset);

				if (Rules.MoveObeysRules(board, testMove, Owner)) {
					if (result == null) {
						result = new Dictionary<(Square, Square), Movement>();
					}
					
					result[(testMove.Start, testMove.End)] = new Movement(testMove);
				}
			}

			return result;
		}
	}
}