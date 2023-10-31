namespace Task3Brackets;
internal class Program
{
	private static void Main(string[] args)
	{
		var stack = new MyStack<int>(10);
		string read = Console.ReadLine();
		for (int i = 0; i < read.Length; i++)
		{
			char c = read[i];
			try
			{
				if (c == '(')
				{
					stack.push(i);
				}
				else if (c == ')')
				{
					stack.pop();
				}
			}
			catch
			{
				Console.WriteLine($"Нет! Лишняя закрывающая скобка на {i+1} позиции.");
				return;
			}
		}
		if (stack.size() == 0)
		{
			Console.WriteLine("Да! Скобки расставлены верно.");
		}
		else
		{
			Console.WriteLine($"Нет! Имеется {stack.size()} лишних открывающих скобок.");
		}
	}
}