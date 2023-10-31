using System;
namespace Task3Brackets
{
	public class MyStack<T>
	{
		T[] stack;
		int head;

		public MyStack(int len)
		{
			stack = new T[len];
			head = -1;
		}

		public void push(T n)
		{
			head += 1;
			if (head >= stack.Length) Array.Resize(ref stack, stack.Length + 10);
			stack[head] = n;
		}

		public T pop()
		{
			if (head == -1) throw new Exception("Empty stack");
			var last = stack[head];
			head -= 1;
			return last;
		}

		public T back()
		{
			if (head == -1) throw new Exception("Empty stack");
			var last = stack[head];
			return last;
		}

		public int size()
		{
			return head + 1;
		}

		public void clear()
		{
			head = -1;
		}
	}
}

