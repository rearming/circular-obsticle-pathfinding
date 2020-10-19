using System;
using System.Collections.Generic;

namespace Pathfinding
{         
	public interface IGraph<T> where T : IEquatable<T>
	{
		void AddNode(Node<T> n);
		void RemoveNode(Node<T> n);
		void ConnectNodes(Node<T> node1, Node<T> node2, int cost = 1);
		void ConnectAllNodes(Action<Node<T>> connectorFunc);

		bool FindNode(Node<T> node, out Node<T> result);
		int Cost(Node<T> current, Node<T> next);
		List<Node<T>> Neighbors(Node<T> current);
	}
}