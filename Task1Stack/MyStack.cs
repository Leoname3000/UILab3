using System;
namespace Task1Stack
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

		public string push(T n)
		{
			head += 1;
			if (head >= stack.Length) Array.Resize(ref stack, stack.Length + 10);
			stack[head] = n;
			return "ok";
		}

		public string pop()
		{
			if (head == -1) return "empty";
			var last = stack[head];
			head -= 1;
			return last.ToString();
		}

		public string back()
		{
			if (head == -1) return "empty";
			var last = stack[head];
			return last.ToString();
		}

		public string size()
		{
			return (head + 1).ToString();
		}

		public string clear()
		{
			head = -1;
			return "ok";
		}

		public string exit()
		{
			return "bye";
		}
	}
}

