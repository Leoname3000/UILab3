namespace Task1Stack;
internal class Program
{
	private static void Main(string[] args)
	{
		var stack = new MyStack<int>(100);
		bool endOfWork = false;

		var log = new List<string>();
		while(!endOfWork)
		{
			string[] input = Console.ReadLine().Split(' ');
			string command = input[0];

			string result;
			switch(command)
			{
				case "push":
					var num = Convert.ToInt32(input[1]);
					result = stack.push(num);
					break;
				case "pop":
					result = stack.pop();
					break;
				case "back":
					result = stack.back();
					break;
				case "size":
					result = stack.size();
					break;
				case "clear":
					result = stack.clear();
					break;
				case "exit":
					result = stack.exit();
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
		foreach(var l in log)
		{
			Console.WriteLine(l);
		}
	}
}