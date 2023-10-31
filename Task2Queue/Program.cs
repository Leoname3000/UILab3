namespace Task2Queue;
internal class Program
{
	private static void Main(string[] args)
	{
		var queue = new MyQueue<int>(100);
		bool endOfWork = false;

		var log = new List<string>();
		while (!endOfWork)
		{
			string[] input = Console.ReadLine().Split(' ');
			string command = input[0];

			string result;
			switch (command)
			{
				case "push":
					var num = Convert.ToInt32(input[1]);
					result = queue.push(num);
					break;
				case "pop":
					result = queue.pop();
					break;
				case "front":
					result = queue.front();
					break;
				case "size":
					result = queue.size();
					break;
				case "clear":
					result = queue.clear();
					break;
				case "exit":
					result = queue.exit();
					endOfWork = true;
					break;
				default:
					result = "unknown";
					break;
			}
			//log.Add(result);
			Console.WriteLine(result);
		}
		Console.WriteLine();
		foreach (var l in log)
		{
			Console.WriteLine(l);
		}
	}
}