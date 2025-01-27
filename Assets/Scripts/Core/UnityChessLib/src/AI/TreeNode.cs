using UnityChess.Core.UnityChessLib.src.Base;

namespace UnityChess.Core.UnityChessLib.src.AI {
	public class TreeNode {

		public TreeNode(Board board, int depth) {
			Board = board;
			Depth = depth;
		}

		public Board Board { get; set; }
		public int Depth { get; set; }
	}
}