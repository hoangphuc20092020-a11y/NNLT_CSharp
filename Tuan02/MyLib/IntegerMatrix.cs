using MyLib;
namespace Bai2_4;
public class IntegerMatrix
{
	private int[,] values;

	public IntegerMatrix()
	{
		this.values = new int[0, 0];
	}

	public IntegerMatrix(int rows, int columns)
	{
		if (rows < 0 || columns < 0)
		{
			throw new ArgumentOutOfRangeException();
		}

		this.values = new int[rows, columns];
	}

	public IntegerMatrix(IntegerMatrix other)
	{
		int rows = other.values.GetLength(0);
		int columns = other.values.GetLength(1);
		this.values = new int[rows, columns];

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				this.values[i, j] = other.values[i, j];
			}
		}
	}

	public int Rows
	{
		get { return this.values.GetLength(0); }
	}

	public int Columns
	{
		get { return this.values.GetLength(1); }
	}

	public int this[int row, int column]
	{
		get { return this.values[row, column]; }
		set { this.values[row, column] = value; }
	}

	public void Input()
	{
		for (int i = 0; i < this.Rows; i++)
		{
			for (int j = 0; j < this.Columns; j++)
			{
				Console.Write($"Nhap phan tu [{i}, {j}]: ");
				while (!int.TryParse(Console.ReadLine(), out this.values[i, j]))
				{
					Console.Write("Gia tri khong hop le. Nhap lai: ");
				}
				Console.WriteLine($"Da nhap phan tu [{i}, {j}]: {this.values[i, j]}");
			}
		}
	}

	public void Output()
	{
		for (int i = 0; i < this.Rows; i++)
		{
			for (int j = 0; j < this.Columns; j++)
			{
				Console.Write(this.values[i, j] + " ");
			}

			Console.WriteLine();
		}
	}

	public List<int> PrimeNumbers()
	{
		List<int> result = new List<int>();

		for (int i = 0; i < this.Rows; i++)
		{
			for (int j = 0; j < this.Columns; j++)
			{
				if (IsPrime(this.values[i, j]))
				{
					result.Add(this.values[i, j]);
				}
			}
		}

		return result;
	}

	private static bool IsPrime(int value)
	{
		if (value < 2)
		{
			return false;
		}

		for (int divisor = 2; divisor * divisor <= value; divisor++)
		{
			if (value % divisor == 0)
			{
				return false;
			}
		}

		return true;
	}
}
