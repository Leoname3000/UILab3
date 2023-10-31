namespace Task4Deque;
internal class Program
{
	private static void Main(string[] args)
	{
		var deque = new MyDeque<int>();
		bool endOfWork = false;

		var log = new List<string>();
		while (!endOfWork)
		{
			string[] input = Console.ReadLine().Split(' ');
			string command = input[0];

			string? result = null;
			switch (command)
			{
				case "af":
					var firstNum = Convert.ToInt32(input[1]);
					deque.AddFirst(firstNum);
					result = "ok";
					break;
				case "al":
					var lastNum = Convert.ToInt32(input[1]);
					deque.AddLast(lastNum);
					result = "ok";
					break;
				case "rf":
					result = $"Removed {deque.RemoveFirst()}";
					break;
				case "rl":
					result = $"Removed {deque.RemoveLast()}";
					break;
				case "find":
					var toFind = Convert.ToInt32(input[1]);
					var list = deque.FindData(toFind);
					result = "Found at ";
					foreach (var l in list)
					{
						result += l.ToString() + " ";
					}
					if (list.Count == 0) result = "Found none";
					break;
				case "ri":
					var index = Convert.ToInt32(input[1]);
					result = $"Removed {deque.RemoveIndex(index)}";
					break;
				case "rd":
					var data = Convert.ToInt32(input[1]);
					deque.RemoveData(data);
					result = $"Removed all {data}";
					break;
				case "print":
					deque.Print();
					break;
				case "exit":
					result = "bye";
					endOfWork = true;
					break;
				default:
					result = "unknown";
					break;
			}
			if (result != null)
			{
				Console.WriteLine(result);
			}
		}
	}
}