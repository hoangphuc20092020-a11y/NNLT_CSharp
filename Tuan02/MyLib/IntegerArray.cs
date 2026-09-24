using MyLib;
namespace Bai2_3;
public class IntegerArray
{
	private int[] values;

	public IntegerArray()
	{
		this.values = new int[0];
	}

	public IntegerArray(int n)
	{
		if (n < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(n));
		}

		this.values = new int[n];
	}

	public IntegerArray(IntegerArray other)
	{
		this.values = new int[other.values.Length];
		Array.Copy(other.values, this.values, other.values.Length);
	}

	public int Length
	{
		get { return this.values.Length; }
	}

	public int this[int index]
	{
		get { return this.values[index]; }
		set { this.values[index] = value; }
	}

	public void Input()
	{
		for (int i = 0; i < this.values.Length; i++)
		{
			Console.Write($"Nhap phan tu thu {i}: ");
			while (!int.TryParse(Console.ReadLine(), out this.values[i]))
			{
				Console.Write("Gia tri khong hop le. Nhap lai: ");
			}
			Console.WriteLine($"Da nhap phan tu thu {i}: {this.values[i]}");
		}
	}

	public void Output()
	{
		Console.WriteLine(string.Join(" ", this.values));
	}

	public List<int> EvenNumbers()
	{
		List<int> result = new List<int>();

		foreach (int value in this.values)
		{
			if (value % 2 == 0)
			{
				result.Add(value);
			}
		}

		return result;
	}
}

