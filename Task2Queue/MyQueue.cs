using System;
namespace Task2Queue
{
	public class MyQueue<T>
	{
		T[] queue;
		int head;
		int tail;

		public MyQueue(int len)
		{
			queue = new T[len];
			head = 0;
			tail = -1;
		}

		public string push(T n)
		{
			if (tail - head != -1 && tail % queue.Length - head % queue.Length == -1) return "full";
			tail += 1;
			queue[tail % queue.Length] = n;
			return "ok";
		}

		public string pop()
		{
			if (tail - head == -1) return "error";
			var first = queue[head % queue.Length];
			head += 1;
			return first.ToString();
		}

		public string front()
		{
			if (tail - head == -1) return "error";
			var first = queue[head % queue.Length];
			return first.ToString();
		}

		public string size()
		{
			return (tail - head + 1).ToString();
		}

		public string clear()
		{
			head = 0;
			tail = -1;
			return "ok";
		}

		public string exit()
		{
			return "bye";
		}
	}
}

