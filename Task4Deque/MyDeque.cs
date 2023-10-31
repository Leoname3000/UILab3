using System;
namespace Task4Deque
{
	public class MyDeque<T>
	{
		public MyDeque()
		{
			Head = null;
		}
		DoublyNode<T>? Head { get; set; }

		public void AddFirst(T data)
		{
			var node = new DoublyNode<T>(data);
			if (Head != null)
				Head.Prev = node;
			node.Next = Head;
			Head = node;
		}
		public T RemoveFirst()
		{
			if (Head == null) throw new Exception("Empty deque");
			var data = Head.Data;
			Head = Head.Next;
			if (Head != null)
				Head.Prev = null;
			return data;
		}
		public void AddLast(T data)
		{
			var node = new DoublyNode<T>(data);
			if (Head == null)
			{
				Head = node;
				return;
			}
			var current = Head;
			while(current.Next != null)
			{
				current = current.Next;
			}
			current.Next = node;
			node.Prev = current;
		}
		public T RemoveLast()
		{
			if (Head == null) throw new Exception("Empty deque");
			var current = Head;
			while (current.Next != null)
			{
				current = current.Next;
			}
			var data = current.Data;
			if (current.Prev != null)
			{
				current.Prev.Next = null;
			}
			else
			{
				Head = null;
			}
			return data;
		}

		public List<int> FindData(T data)
		{
			if (Head == null) throw new Exception("Empty deque");
			var list = new List<int>();
			int index = 0;
			var current = Head;
			do
			{
				if (current.Data.Equals(data))
					list.Add(index);
				current = current.Next;
				index++;
			}
			while (current != null);
			return list;
		}
		public T RemoveIndex(int index)
		{
			if (Head == null) throw new Exception("Empty deque");
			var current = Head;
			for (int i = 0; i < index; i++)
			{
				if (current.Next == null) throw new Exception("Index out of range");
				current = current.Next;
			}
			var data = current.Data;
			if (current.Next != null)
				current.Next.Prev = current.Prev;
			if (current.Prev != null)
				current.Prev.Next = current.Next;
			else
				Head = current.Next;
			return data;
		}
		public void RemoveData(T data)
		{
			if (Head == null) throw new Exception("Empty deque");
			var list = FindData(data);
			int removed = 0;
			foreach(var i in list)
			{
				RemoveIndex(i - removed);
				removed++;
			}
		}
		public void Print()
		{
			if (Head == null)
			{
				Console.WriteLine("empty");
				return;
			}
			string result = "";
			var current = Head;
			do
			{
				result += current.Data.ToString() + " ";
				current = current.Next;
			}
			while(current != null);
			Console.WriteLine(result);
		}
	}
}

